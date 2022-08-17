using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.SignalRHub
{
     
    public class UsersDmHub : Hub
    {
        private UserInfoInMemory _userInfoInMemory;
        public UsersDmHub(UserInfoInMemory userInfoInMemory)
        {
            _userInfoInMemory = userInfoInMemory;
        }

        public async Task Leave()
        {
            _userInfoInMemory.Remove(Context.ConnectionId);
            await Clients.AllExcept(new List<string> { Context.ConnectionId }).SendAsync(
                   "UserLeft",
                   Context.ConnectionId
                   );
        }

        public async Task Join()
        {
            //var name = ClaimsPrincipal.Current.Identity.Name;

            if (!_userInfoInMemory.AddUpdate(Context.User.Identity.Name, Context.ConnectionId))
            {
                // Người dùng join
                var list = _userInfoInMemory.GetAllUsersExceptThis(Context.ConnectionId).ToList();
                await Clients.AllExcept(new List<string> { Context.ConnectionId }).SendAsync(
                    "NewOnlineUser",
                    _userInfoInMemory.GetUserInfo(Context.ConnectionId)
                    );
            } 

            await Clients.Client(Context.ConnectionId).SendAsync(
                "Joined",
                _userInfoInMemory.GetUserInfo(Context.ConnectionId)
                );

            await Clients.Client(Context.ConnectionId).SendAsync(
                "OnlineUsers",
                _userInfoInMemory.GetAllUsersExceptThis(Context.ConnectionId)
            );
        }

        public Task SendDirectMessage(string message, string targetUserName)
        {
            var userInfoSender = _userInfoInMemory.GetUserInfo(Context.ConnectionId);
            var userInfoReciever = _userInfoInMemory.GetUserInfo(targetUserName);
            return Clients.Client(userInfoReciever.ConnectionId).SendAsync("SendDM", message, userInfoSender);
        }
    }
}

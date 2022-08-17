using System;
using System.Collections.Generic;
using System.Text;
using Interfaces.Base;
namespace Interfaces.Models.Tradingsession
{
    public class TraddingSessionDeleteRequest : BaseRequest
    {
        public int Id { get; set; }
    }
}

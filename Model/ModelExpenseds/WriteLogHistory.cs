using System;
using System.Collections.Generic;
using System.Text;

namespace Model.ModelExpenseds
{
    public class WriteLogHistory
    {
        private object p;
        private string v;
        private byte? trangThai;
        private int accountId;
        private DateTime now;

        public WriteLogHistory( int objectId, int? type, string contents, byte status, long createdBy, DateTime createdDate, int typeCheck)
        {
            ObjectId = objectId;
            Type = type;
            Contents = contents;
            Status = status;
            CreatedBy = createdBy;
            CreatedDate = createdDate;
            TypeCheck = typeCheck;
        }

  

        public int Id { get; set; }
        public int ObjectId { get; set; }
        public int? Type { get; set; }
        public string Contents { get; set; }
        public byte Status { get; set; }
        public long CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public int TypeCheck { get; set; }
       
    }
}
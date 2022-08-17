using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces.Models.Business
{
    public class DeleteBusinessRequest : BaseRequest
    {
        public int Id { get; set; }
    }

    
}

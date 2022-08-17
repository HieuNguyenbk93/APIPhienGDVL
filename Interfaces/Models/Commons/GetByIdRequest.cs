using Interfaces.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Interfaces.Models.Commons
{
    public class GetByIdRequest : BaseRequest
    {
        [Required]
        public int Id { get; set; }
        public short? Type { get; set; }
    }
}

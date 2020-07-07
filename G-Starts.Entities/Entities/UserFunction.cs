using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Starts.Entities.Entities
{
    public partial class UserFunction
    {
        [Key]
        public int Id { get; set; }
        public int? UserId { get; set; }
        [StringLength(150)]
        public string FunctionCode { get; set; }
    }
}

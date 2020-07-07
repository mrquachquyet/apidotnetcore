using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Starts.Entities.Entities
{
    [Table("sysFunctionGroupFunction")]
    public partial class SysFunctionGroupFunction
    {
        [Key]
        public int Id { get; set; }
        public int? FunctionId { get; set; }
        public int? GroupFunctionId { get; set; }
    }
}

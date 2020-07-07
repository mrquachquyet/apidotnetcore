using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Starts.Entities.Entities
{
    public partial class Config
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Key { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        public string Description { get; set; }
        public string Value { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

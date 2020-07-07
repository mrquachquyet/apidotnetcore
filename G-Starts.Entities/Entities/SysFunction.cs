using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Starts.Entities.Entities
{
    [Table("sysFunction")]
    public partial class SysFunction
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string Key { get; set; }
        [StringLength(512)]
        public string Name { get; set; }
        [StringLength(512)]
        public string VnName { get; set; }
        public string Description { get; set; }
        [StringLength(150)]
        public string ControllerName { get; set; }
        [StringLength(150)]
        public string ActionName { get; set; }
        public int? OrderBy { get; set; }
        public bool? ShowOnMenu { get; set; }
        public int? Status { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        public int? MenuGroupId { get; set; }
    }
}

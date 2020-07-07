using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace G_Starts.Entities.Entities
{
    public partial class User
    {
        [Key]
        public int Id { get; set; }
        [StringLength(150)]
        public string UserName { get; set; }
        [StringLength(50)]
        public string SaltKey { get; set; }
        [StringLength(250)]
        public string Password { get; set; }
        [StringLength(250)]
        public string Email { get; set; }
        [StringLength(150)]
        public string FirstName { get; set; }
        [StringLength(150)]
        public string LastName { get; set; }
        public int? Status { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [StringLength(512)]
        public string Avatar { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? CreatedDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

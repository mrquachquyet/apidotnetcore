using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace G_Stars.Models.User
{
    public class UserModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="User name không được để trống")]
        [MaxLength(150, ErrorMessage ="User name không được vượt quá 150 ký tự")]
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
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? CreatedBy { get; set; }
        public int? UpdatedBy { get; set; }
    }
}

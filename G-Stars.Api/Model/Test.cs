using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace G_Stars.Api.Model
{
    public class Test
    {
        [Required(ErrorMessage = "Id không được bỏ trống")]
        public int? Id { get; set; }
        [MaxLength(3, ErrorMessage = "Max length không được lơn hơn 3")]
        public string Message { get; set; }
    }
}

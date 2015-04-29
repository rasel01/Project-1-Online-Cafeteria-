using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UiuCanteen.WebUi.Models
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "UserName is Required")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "UserName is Required")]
        [StringLength(50, MinimumLength = 4)]
        public string Password { get; set; }
    }
}
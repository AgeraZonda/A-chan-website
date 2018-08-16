using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace A_chan_website.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage="Mời nhập username")]
        public string username { get; set; }
        [Required(ErrorMessage = "Mời nhập password")]
        public string password { get; set; }
        public bool rememberMe { get; set; }
    }
}
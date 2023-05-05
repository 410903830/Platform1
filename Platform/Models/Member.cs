using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Platform.Models
{
    public class Member
    {
        public int id { get; set; }



        [Display(Name = "暱稱")]
        [Required(ErrorMessage = "請輸入暱稱")]
        public string Name { get; set; }

        [Display(Name = "帳號"), Required(ErrorMessage = "請輸入帳號")]
        public string Account { get; set; }

        [Display(Name = "信箱"), Required(ErrorMessage = "請輸入信箱")]
        public string Email { get; set; }

        [Required(ErrorMessage = "請輸入正確密碼")]
        public string Password { get; set; }

        [Required(ErrorMessage = "請輸入密碼")]
        public string CorrectPassword { get; set; }

        public bool rememberPassword { get; set; }
    }
}
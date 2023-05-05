using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Platform.Models
{
    public class signmember
    {
        [Display(Name = "暱稱"), DataType(DataType.Text)]
        [Required]
        public string name { get; set; }

        [Display(Name = "帳號"), DataType(DataType.Text)]
        [Required]
        public string account { get; set; }

        [Display(Name = "密碼"), DataType(DataType.Password)]
        [Required]
        public string password { get; set; }

        [Display(Name = "確認密碼"), DataType(DataType.Password)]
        [Required]
        public string confirm_password { get; set; }

        [Display(Name = "信箱"), DataType(DataType.EmailAddress)]
        [Required]
        public string email { get; set; }

        [Display(Name = "驗證碼"), DataType(DataType.Text)]
        [Required]
        public string code { get; set; }


        [Display(Name = "生日"), DataType(DataType.Date)]
        [Required]
        public DateTime birthday { get; set; }

        [Display(Name = "身分")]
        [Required]
        public string indentity { get; set; }
    }
}
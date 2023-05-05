using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace Platform.Models
{
    public class member_info
    {
        [Display(Name = "暱稱"), DataType(DataType.Text)]
        public string name { get; set; }

        [Display(Name = "帳號"), DataType(DataType.Text)]
        public string account { get; set; }

        [Display(Name = "密碼"), DataType(DataType.Password)]
        public string password { get; set; }

        [Display(Name = "信箱"), DataType(DataType.EmailAddress)]
        public string email { get; set; }

        [Display(Name = "生日"), DataType(DataType.Date)]
        public DateTime birthday { get; set; }

        [Display(Name = "身分")]
        public string indentity { get; set; }
    }
}
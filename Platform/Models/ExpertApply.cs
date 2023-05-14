using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Platform.Models
{
    public class ExpertApply
    {

        [Display(Name = "ExpertApplyID")]
        public int ExpertApplyID { get; set; }

        [Display(Name = "UserID")]
        public int UserID { get; set; }


        [Display(Name = "專業領域")]
        public string ExpertField { get; set; }

        [Display(Name = "證照/畢業證書")]
        public string ExpertLicense { get; set; }

        [Display(Name = "個人簡介")]
        public string ExpertInfo { get; set; }

        [Display(Name = "備註")]
        public string Remark { get; set; }

        /// <summary>
        /// ///////////////////////////////////////////
        /// </summary>

        [Display(Name = "身分")]
        public string Status { get; set; }

        [Display(Name = "專家大頭貼")]
        public string ExpertImgURL { get; set; }







    }
}
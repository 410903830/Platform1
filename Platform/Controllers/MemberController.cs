﻿using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Platform.Controllers
{
    public class MemberController : Controller
    {
        // GET: Member
        public ActionResult login()
        {
            return View();
        }

        public ActionResult Sign()
        {
            return View();
        }

        public ActionResult forget_password()
        {
            return View();
        }

        public ActionResult member_info()
        {
            return View();
        }

        public ActionResult repair_member()
        {
            return View();
        }

        public ActionResult Apply_expert()
        {
            return View();
        }


    }

}
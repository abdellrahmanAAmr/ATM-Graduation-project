﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ATM_Application.Controllers
{
    public class ATMMinistryController : BaseController
    {
        // GET: ATMMinistry
        public ActionResult Index()
        {
            return View();
        }
    }
}
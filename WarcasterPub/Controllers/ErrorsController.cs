﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WarcasterPub.Controllers
{
    public class ErrorsController : Controller
    {
        // GET: Error
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult NotFound()
		{
			return View();
		}
    }
}
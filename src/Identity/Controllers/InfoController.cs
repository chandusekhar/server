﻿using System;
using Microsoft.AspNetCore.Mvc;
using Bit.Core.Utilities;

namespace Bit.Identity.Controllers
{
    public class InfoController : Controller
    {
        [HttpGet("~/alive")]
        [HttpGet("~/now")]
        public DateTime GetAlive()
        {
            return DateTime.UtcNow;
        }
        
        [HttpGet("~/version")]
        public JsonResult GetVersion()
        {
            return Json(CoreHelpers.GetVersion());
        }
    }
}
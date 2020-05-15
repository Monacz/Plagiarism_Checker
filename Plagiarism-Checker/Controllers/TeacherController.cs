﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Plagiarism_Checker.Controllers
{
    [Authorize(Roles = "Teacher")]

    public class TeacherController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
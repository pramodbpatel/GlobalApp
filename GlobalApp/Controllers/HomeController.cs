﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using GlobalApp.Models;
using Microsoft.Extensions.Localization;
using GlobalApp.Resources;
using Microsoft.AspNetCore.Localization;
using Microsoft.AspNetCore.Http;

namespace GlobalApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IStringLocalizer<HomeController> _localizer;
        private readonly LocService _sharedLocalizer;

        public HomeController(IStringLocalizer<HomeController> localizer, LocService sharedLocalizer)
        {
            _localizer = localizer;
            _sharedLocalizer = sharedLocalizer;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = String.Format("{0} and {1}", _localizer["Home"], _sharedLocalizer.GetLocalizedHtmlString("Shared"));

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpPost]
        public IActionResult SetLanguage(string culture, string returnUrl)
        {
            Response.Cookies.Append(
                CookieRequestCultureProvider.DefaultCookieName,
                CookieRequestCultureProvider.MakeCookieValue(new RequestCulture(culture)),
                new CookieOptions { Expires = DateTimeOffset.UtcNow.AddYears(1) }
            );
            string[] newUrl = returnUrl.Split('/');
            if (newUrl[1] == "en" || newUrl[1] == "fr")
            {
                newUrl[1] = culture;
                returnUrl = string.Join("/", newUrl);
            }
            else
            {
                returnUrl = "~/" + culture + returnUrl.Replace("~","");
            }
            return LocalRedirect(returnUrl);
        }
    }
}

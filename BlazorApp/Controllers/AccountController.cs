using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BlazorApp.Controllers
{
    [Authorize]
    public class AccountController : ControllerBase
    {
        [Route("/account/login")]
        public IActionResult Login()
        {
            return Redirect("/");
        }
    }
}

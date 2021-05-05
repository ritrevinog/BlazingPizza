﻿using BlazingPizza.Shared;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.Twitter;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Server.Controllers
{
    //remove this line [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private static UserInfo LoggedOutUser = new UserInfo { IsAuthenticated = false };

        //Endpoint
        [HttpGet("user")]
        public UserInfo GetUser()
        {
            return User.Identity.IsAuthenticated
               ? new UserInfo { IsAuthenticated = true, Name = User.Identity.Name }
               : LoggedOutUser;
        }

        [HttpGet("user/sigin")]
        public async Task SignIn(string redirectUri)
        {
            if (string.IsNullOrEmpty(redirectUri) || !Url.IsLocalUrl(redirectUri))
            {
                redirectUri = "/";
            }

            await HttpContext.ChallengeAsync(TwitterDefaults.AuthenticationScheme,
                new AuthenticationProperties
                {
                    RedirectUri = redirectUri
                });
        }

        [HttpGet("user/signout")]
        public async Task<IActionResult> SignOut()
        {
            await HttpContext.SignOutAsync(
                CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("~/");
        }

    }
}

﻿using BL.Manager;
using Microsoft.Owin.Security.OAuth;
using Model.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using System.Web;

namespace LMS.Providers
{
    public class TokenBasedOauthProvider : OAuthAuthorizationServerProvider
}
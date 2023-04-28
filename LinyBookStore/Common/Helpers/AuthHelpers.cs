﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Security.Principal;
namespace LinyBookStore.Common.Helpers
{
    public static class AuthHelpers
    {
        
        public static string GetName(this IIdentity identity)
        {
            return identity.GetUserData().Name;
        }
        public static int GetUserId(this IIdentity identity)
        {
            return identity.GetUserData().UserId;
        }
        public static string GetEmail(this IIdentity identity)
        {
            return identity.GetUserData().Email;
        }
        public static string GetAvatar(this IIdentity identity)
        {
            return identity.GetUserData().Avatar;
        }
        public static int GetRole(this IIdentity identity)
        {
            return identity.GetUserData().RoleCode;
        }
        public static LoggedUserData GetUserData(this IIdentity identity)
        {
            var jsonUserData = HttpContext.Current.User.Identity.Name;
            var userData = JsonConvert.DeserializeObject<LoggedUserData>(jsonUserData);
            return userData;
        }
    }
}
﻿using PlantShop.Areas.Admin;
using System.Security.Claims;

namespace PlantShop.Infrastructure
{
    using static AdminConstants;

    public static class ClaimsPrincipalExtensions
    {        
        public static string Id(this ClaimsPrincipal user)
            => user.FindFirst(ClaimTypes.NameIdentifier).Value;

        public static bool IsAdmin(this ClaimsPrincipal user)
            => user.IsInRole(AdminRoleName);
    }
}

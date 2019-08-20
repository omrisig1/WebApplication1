using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using OtoSpaMVC.Models;
using OtoSpaMVC.Data;

namespace OtoSpaMVC.Services
{
    public class GlobalFunctionality
    {
        public static string GetCurrentUserID(HttpContext httpContext)
        {
            // string UserID = User.Identity.Name; // email/name
            //ApplicationUser applicationUser = _context.Users.SingleOrDefault(ua => ua.UserName.Equals(User.Identity.Name));
            //string UserID = (applicationUser == null) ? null : applicationUser.Id;

            Claim UserIdClaim = httpContext.User.FindFirst(ClaimTypes.NameIdentifier);
            if (UserIdClaim == null)
                return null;
            return UserIdClaim.Value;
        }
        public static async Task<IEnumerable<IdentityRole>> GetUserRole(ApplicationUser user, ApplicationDbContext _context)
        {
            var usrRl = from ur in _context.UserRoles
                      where ur.UserId == user.Id
                      select ur;
            var roles = from r in _context.Roles
                        select r;

            var joined = usrRl.Join(roles, u => u.RoleId, r => r.Id,
                (ur, r) => new { Ur = ur, R = r }).Select(x => x.R);
            return joined.ToList();
        }
        public static bool IsAjaxRequest(HttpRequest request)
        {
            if (request == null)
                throw new ArgumentNullException("request");

            if (request.Headers != null)
                return request.Headers["X-Requested-With"] == "XMLHttpRequest";
            return false;
        }
    }
}

using System.Security.Claims;

namespace fhj_est_customer_portal
{
    public static class Extentions
    {
        public static string GetFullName(this ClaimsPrincipal principal) => 
            principal.FindFirstValue(AppConstants.ClaimNames.FullName)!;
        public static string GetUserId(this ClaimsPrincipal principal) =>
          principal.FindFirstValue(ClaimTypes.NameIdentifier)!;

    }
}

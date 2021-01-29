using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimsPrincipleExtenstion
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

        public static int GetUserId(this ClaimsPrincipal user)
        {
            string test = user.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            return int.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}
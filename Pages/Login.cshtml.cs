using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;
using mhmdhidry.BLL;

namespace mhmdhidry.Pages
{
	public class LoginModel : PageModel
	{
		public bool hasError { get; set; }
		private Users users = new Users();
		public IActionResult OnGet(string returnUrl = null)
		{
			ViewData["ReturnUrl"] = returnUrl;
			if (User.Identity.IsAuthenticated)
				Response.Redirect("/Admin");
			return Page();
		}
		public async Task<IActionResult> OnPostLogin(string username, string password, string remember, string returnUrl = null)
		{
			users.Filter = 5;
			users.UsrName = username;
			users.UsrPass = password;
			users.Retrieve();
			List<Users> user = users.Retrieve();
			if (user.Count > 0)
			{
				var claims = new List<Claim>
			{
				new Claim(ClaimTypes.Name, user[0].UsrID.ToString()),
                //new Claim(ClaimTypes.UserData, users[0].UsrCode.ToString()),
            };
				var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

				var principal = new ClaimsPrincipal(identity);

				var properties = new AuthenticationProperties
				{
					IsPersistent = remember.ToBoolean()
				};

				await HttpContext.SignInAsync(principal, properties);
				return Redirect(returnUrl ?? "/Admin");
			}
			else
			{
				hasError = true;
				return Page();
			}
		}
	}
}
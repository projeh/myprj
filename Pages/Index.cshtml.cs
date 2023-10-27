using mhmdhidry.BLL;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Claims;

namespace mhmdhidry.Pages
{
    public class IndexModel : PageModel
    {
		public Subscribe subscribe = new Subscribe();
		public Users usr = new Users();
        public List<Users> users { get; set; }
		public List<Subscribe> subscribes { get; set; }
		public void OnGet()
        {
        }

		public IActionResult OnGetLogin(string mobile)
		{
			usr.Filter = 3;
			usr.UsrMobile = mobile;
			users = usr.Retrieve();
			if (users.Count > 0)
				return new JsonResult("true");
			else
				return new JsonResult("false");
		}

		public IActionResult OnGetSubscribe(string mobile)
        {
            subscribe.SbcMobile = mobile;
            subscribe.Insert();
			return new JsonResult("success");
		}

        public IActionResult OnPostRegister(string mobile, string fullname, string code, bool remember)
        {
            usr.Filter = 4;
            usr.UsrCode = code;
            usr.UsrMobile = mobile;
            users = usr.Retrieve();
            if (users.Count > 0)
            {
                var claims = new List<Claim>
            {
                new Claim(ClaimTypes.Name, mobile),
            };
                var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

                var principal = new ClaimsPrincipal(identity);

                var properties = new AuthenticationProperties
                {
                    IsPersistent = remember
                };

                HttpContext.SignInAsync(principal, properties);
                return new JsonResult("true");
            }

            else
                return new JsonResult("false");
        }
    }
}
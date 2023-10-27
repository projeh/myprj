using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mhmdhidry.Pages
{
    public class DevregModel : PageModel
    {
		public IActionResult OnGet()
		{
			return Redirect("/Landing/Devreg");
		}
	}
}
using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data;

namespace mhmdhidry.Pages
{
    public class edit_crsModel : PageModel
    {
	
		public CoursRegister crs = new CoursRegister();
		[BindProperty]
		public List< CoursRegister> crsreg { get; set; }
		//public CoursRegister crsreg { get; set; }

		public void OnGet(int id)
		{
			crs.CrgID = id;

			crsreg = crs.Retrieve(3);
			ViewData["crsf"] = crsreg[0].CrgFullName;
			@ViewData["id"] = crsreg[0].CrgID;


		}

		[BindProperty]
		public string CrgFullName { get; set; }
		[BindProperty]
		public int CrgID { get; set; }
		public IActionResult OnPost()
		{
			crs.CrgID = CrgID;
			//crs.CrgFullName = name;
			crs.CrgFullName = CrgFullName;






			 crs.Update(0);

			return RedirectToPage("./showcrsreg");
		}

	}
}

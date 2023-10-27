using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Hosting;
using System.Collections.Generic;
using System.Data;
using System.Reflection;

namespace mhmdhidry.Pages
{
    public class LandingModel : PageModel
    {
        [BindProperty]
		public CoursRegister coursRegister { get; set; }
		public Landings lnd = new Landings();
        public bool IsPost = false;
		public IActionResult OnGet(string name)
        {
			Library.RemoveSession(HttpContext, "Message");
			Library.RemoveSession(HttpContext, "LndDesc");
			Library.RemoveSession(HttpContext, "CrgSecurityCode");
			Library.RemoveSession(HttpContext, "LndUseConfirm");
			Refresh(name);
			DataTable tbl = new DataTable();
			lnd.LndCode = name;
            tbl = lnd.Retrieve(1);
            if(tbl.Rows.Count > 0)
            {
				ViewData["Title"] = tbl.Rows[0]["LndTitle"];
				ViewData["CrgLndCode"] = tbl.Rows[0]["LndCode"];
				ViewData["LndPoster"] = tbl.Rows[0]["LndPoster"];
				ViewData["LndVideo"] = tbl.Rows[0]["LndVideo"];
				return Page();
			}
            else
				return Redirect("/");
		}
		public IActionResult OnPostSubmitRegister()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
			Submit();
			Refresh(coursRegister.CrgLndCode);
			IsPost = true;
			return Page();
        }
		public IActionResult OnPostSubmitCode(string LndCode, string CrgSecurityCode)
		{
			if (CrgSecurityCode == Library.GetSession(HttpContext, "CrgSecurityCode"))
			{
				Library.RemoveSession(HttpContext, "CrgSecurityCode");
				Library.RemoveSession(HttpContext, "LndUseConfirm");
			}
			else
				TempData["Error"] = "کد وارد شده اشتباه است.";
			Refresh(LndCode);
			IsPost = true;
			return Page();
		}
		void Submit()
		{
			CoursRegister crg = new CoursRegister();
			List<CoursRegister> list = new List<CoursRegister>();
			crg.CrgFullName = coursRegister.CrgFullName;
			crg.CrgMobile = coursRegister.CrgMobile;
			crg.CrgLndCode = coursRegister.CrgLndCode;
			list = crg.Insert();
			int CrgID = (int)list.FirstOrDefault().CrgID;
			Library.SetSession(HttpContext, "Message", list.FirstOrDefault().LndSuccessMessage);
			Library.SetSession(HttpContext, "LndDesc", list.FirstOrDefault().LndDesc);
			Library.SetSession(HttpContext, "CrgSecurityCode", list.FirstOrDefault().CrgSecurityCode);
			Library.SetSession(HttpContext, "LndUseConfirm", list.FirstOrDefault().LndUseConfirm.ToString());
			//return RedirectToPage("./Index");
		}
		void Refresh(string LndCode)
		{
			string[] PageUrl = $"{Library.domain(Request)}".Split("?");
			ViewData["LndCode"] = LndCode;
			ViewData["PageUrl"] = PageUrl[0];
		}
	}
}
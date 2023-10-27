using mhmdhidry.BLL;
using Microsoft.AspNetCore.Hosting.Server;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace mhmdhidry.Pages
{
    public class reg_crsModel : PageModel
    {
        public void OnGet()
        {
        }

		public CoursRegister crs = new CoursRegister();
		//[BindProperty]
		//public string url { get; set; }
		[BindProperty]
		public IFormFile CrgFullName { get; set; }
		[BindProperty]
		public int CrgID { get; set; }

		public async Task<IActionResult> OnPostAsync()
        {

			//var uploads = Path.Combine(_environment.WebRootPath, "uploads");
			//var uploads = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", CrgFullName.FileName);

			//if (CrgFullName.Length > 0)
			//	{
			//		using (var fileStream = new FileStream(Path.Combine(uploads, CrgFullName.FileName), FileMode.Create))
			//		{
			//			await CrgFullName.CopyToAsync(fileStream);
			//		}
			//	}

			//////	////if (Path.GetExtension(CrgFullName.FileName) == ".jpg" || Path.GetExtension(CrgFullName.FileName) == ".png")
			//////	//{



			//////	string filename = Guid.NewGuid() + CrgFullName.FileName;
			//////	//	//string url = Server.MapPath("~/picservice/" + filename);

			//////	//	//CrgFullName.FileBase.SaveAs(url);
			//////	//	////..pics.Url_service = filename;
			//////	//}
			var filename = ContentDispositionHeaderValue.Parse(CrgFullName.ContentDisposition).FileName.Trim('"');
			var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", CrgFullName.FileName);
			using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
			{
				await CrgFullName.CopyToAsync(stream);
			}


			//////	string fileName1 = Path.GetFileName(CrgFullName.FileName);
			//////	//using (MemoryStream ms = new MemoryStream())
			//////	//{
			//////	//	CrgFullName.CopyTo(ms);

			//////	//}
			crs.CrgFullName = filename;

			crs.Insert();

			return RedirectToPage("./showcrsreg");
		}
    }
}

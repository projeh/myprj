using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http.Headers;

namespace mhmdhidry.Pages
{
    public class Reg_pakageModel : PageModel
    {
		public void OnGet()
		{
		}

		public Package pkg = new Package();
		//[BindProperty]
		//public string url { get; set; }
		[BindProperty]
		public IFormFile pkg_pic { get; set; }
		[BindProperty]
		public int PkgId { get; set; }
		[BindProperty]
		public string Pkg_Name { get; set; }
		[BindProperty]
		public string Pkg_Teacher { get; set; }
		[BindProperty]
		public decimal Pkg_Price { get; set; }
		[BindProperty]
		public string dsc { get; set; }

		[BindProperty]
		public string status { get; set; }
		[BindProperty]
		public DateTime Pkg_date { get; set; }

		[BindProperty]
		public int Pkg_dur { get; set; }

		[BindProperty]
		public string Pkg_tag { get; set; }
		[BindProperty]
		public string Pkg_more_dsc { get; set; }
		[BindProperty]
		public string Pkg_cat { get; set; }
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
			var filename = ContentDispositionHeaderValue.Parse(pkg_pic.ContentDisposition).FileName.Trim('"');
			var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "images", pkg_pic.FileName);
			using (System.IO.Stream stream = new FileStream(path, FileMode.Create))
			{
				await pkg_pic.CopyToAsync(stream);
			}


			//////	string fileName1 = Path.GetFileName(CrgFullName.FileName);
			//////	//using (MemoryStream ms = new MemoryStream())
			//////	//{
			//////	//	CrgFullName.CopyTo(ms);

			//////	//}
			pkg.Pkg_Pic = filename;
			pkg.Pkg_Teacher=Pkg_Teacher;
			pkg.Pkg_tag=Pkg_tag;
			pkg.Pkg_cat=Pkg_cat;
			pkg.Pkg_Dur = Pkg_dur;
			pkg.Pkg_Name = Pkg_Name;
			pkg.dsc = dsc;
			pkg.Pkg_Price = Pkg_Price;
			pkg.status = status;

			pkg.Insert();

			return RedirectToPage("./show_pkg");
		}
	}
}

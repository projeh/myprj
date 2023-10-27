using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mhmdhidry.Pages
{
    public class show_pkgModel : PageModel
    {

        public Package pkg = new Package();
        public List<Package> pakage { get; set; }
        public void OnGet()
        {
            pakage = pkg.Retrieve(3);

        }
    }
}

using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;

namespace mhmdhidry.Pages
{
    public class showcrsregModel : PageModel
    {


        public CoursRegister crs = new CoursRegister();
        public List<CoursRegister> crsreg { get; set; }
        public DataSet ds_crs_reg { get; set; }
      //  string constr = "Data Source=betarjom.com;Initial Catalog=MhmdHidry222;Persist Security Info=True;User ID=Ghorbani;Password=Gh136200";

        public void OnGet()
        {
          



            crsreg = crs.Retrieve(0);


        }
    }
}
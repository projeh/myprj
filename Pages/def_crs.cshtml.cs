using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Data.SqlClient;
using System.Data;

namespace mhmdhidry.Pages
{
    public class def_crsModel : PageModel
    {
		
			public CoursRegister crs = new CoursRegister();
			public List<CoursRegister> crsreg { get; set; }
			public DataSet ds_crs_reg { get; set; }
			string constr = "Data Source=betarjom.com;Initial Catalog=MhmdHidry222;Persist Security Info=True;User ID=Ghorbani;Password=Gh136200";

			public void OnGet()
			{
				//usr.Filter = 3;
				//usr.UsrMobile = mobile;
				//users = usr.Retrieve();
				//if (users.Count > 0)
				//    return new JsonResult("true");
				//else
				//    return new JsonResult("false");
				//crs.Filter = 1;



				crsreg = crs.Retrieve(0);

				if (crsreg.Count > 0)
				{
					using (SqlConnection con = new SqlConnection(constr))
					{
						string query = "SELECT * FROM CoursRegister";
						using (SqlCommand cmd = new SqlCommand(query, con))
						{
							using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
							{
								ds_crs_reg = new DataSet();
								sda.Fill(ds_crs_reg);
							}
						}
					}
				}

				//    return new JsonResult("true");
				//else
				//    return new JsonResult("false");

			}
		}
	}
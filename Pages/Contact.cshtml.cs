using mhmdhidry.BLL;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace mhmdhidry.Pages
{
    public class ContactModel : PageModel
    {
        public Contact contact = new Contact();
        public List<Contact> contacts { get; set; }
        public void OnGet()
        {
        }
		public void OnPost(string fullName, string mobile, string message)
		{

            contact.CntFullName = fullName;
            contact.CntMobile = mobile;
            contact.CntMessage = message;
            contact.Insert();
            ViewData["Status"] = "success";
        }
	}
}

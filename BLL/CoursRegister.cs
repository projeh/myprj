using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace mhmdhidry.BLL
{
	public class CoursRegister
	{

		private DAL.Base DalBase = new DAL.Base();

		public CoursRegister()
		{

		}

		[Display(Name = "کد")]
		public int CrgID { get; set; } = 0;

		[Required(ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید")]
		[Display(Name = "نام و نام خانوادگی")]
		public string CrgFullName { get; set; }

		[Required(ErrorMessage = "لطفا شماره همراه را وارد کنید")]
		[Display(Name = "شماره همراه")]
		public string CrgMobile { get; set; }

		[Display(Name = "تاریخ")]
		public DateTime CrgDT { get; set; } = default;

		[Display(Name = "کد صفحه")]
		public string CrgLndCode { get; set; } = string.Empty;

		public string CrgSecurityCode { get; set; } = string.Empty;

		public string LndDesc { get; set; } = string.Empty;

        public string LndSuccessMessage { get; set; } = string.Empty;

        public bool LndUseConfirm { get; set; } = false;



		public List<CoursRegister> Insert()
		{
			return
			DalBase.CoursRegister_Insert(

			CrgID
  , CrgFullName
  , CrgMobile
  , CrgDT
  , CrgLndCode
  , CrgSecurityCode
  ).ToList<CoursRegister>();

		}

		public void Update(int Filter)
		{
			DalBase.CoursRegister_Update(

		   Filter
  , CrgID
  , CrgFullName
  , CrgMobile
  , CrgDT
  , CrgLndCode
  , CrgSecurityCode
  );

		}
		public void Delete()
		{
			DalBase.CoursRegister_Delete(CrgID);
		}

		public DataTable Retrieve_2(int Filter)
		{
			return
			DalBase.CoursRegister_Retrieve(

		  Filter
 , CrgID
 , CrgFullName
 , CrgMobile
 , CrgDT
 , CrgLndCode
 , CrgSecurityCode
 );

		}
		public List<CoursRegister> Retrieve(int Filter)
		{
			return
			DalBase.CoursRegister_Retrieve(

		  Filter
 , CrgID
 , CrgFullName
 , CrgMobile
 , CrgDT
 , CrgLndCode
 , CrgSecurityCode
 ).ToList<CoursRegister>();

		}
	}
}
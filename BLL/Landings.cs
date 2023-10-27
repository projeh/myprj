using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace mhmdhidry.BLL
{
	public class Landings
	{

		private DAL.Base DalBase = new DAL.Base();

		public Landings()
		{

		}


		public int LndID { get; set; }

		public string LndTitle { get; set; }

		public string LndCode { get; set; }

		public string LndDesc { get; set; }

		public string LndPoster { get; set; }

		public string LndVideo { get; set; }

		public DateTime LndDT { get; set; }

		public string LndSuccessMessage { get; set; }

		public string LndSmsMessage { get; set; }

        public bool LndUseConfirm { get; set; }


        public void Insert()
		{
			DalBase.Landings_Insert(

			LndID
  , LndTitle
  , LndCode
  , LndDesc
  , LndPoster
  , LndVideo
  , LndDT
  , LndSuccessMessage
  , LndSmsMessage
  );

		}

		public void Update(int Filter)
		{
			DalBase.Landings_Update(

		   Filter
  , LndID
  , LndTitle
  , LndCode
  , LndDesc
  , LndPoster
  , LndVideo
  , LndDT
  , LndSuccessMessage
  , LndSmsMessage
  );

		}
		public void Delete()
		{
			DalBase.Landings_Delete(LndID);
		}
		public DataTable Retrieve(int Filter)
		{
			return
			DalBase.Landings_Retrieve(

		  Filter
 , LndID
 , LndTitle
 , LndCode
 , LndDesc
 , LndPoster
 , LndVideo
 , LndDT
 , LndSuccessMessage
 , LndSmsMessage
 );

		}
	}
}
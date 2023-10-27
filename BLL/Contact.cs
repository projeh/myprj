using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace mhmdhidry.BLL
{
    public class Contact
    {

        private DAL.Base DalBase = new DAL.Base();

        public Contact()
        {

        }


        public int CntID { get; set; }

        public string CntFullName { get; set; }

        public string CntMobile { get; set; }

        public string CntMessage { get; set; }

        public DateTime CntDT { get; set; }


        public List<Contact> Insert()
        {
            return
            DalBase.Contact_Insert(

            CntID
  , CntFullName
  , CntMobile
  , CntMessage
  , CntDT
  ).ToList<Contact>();

        }

        public void Update(int Filter)
        {
            DalBase.Contact_Update(

           Filter
  , CntID
  , CntFullName
  , CntMobile
  , CntMessage
  , CntDT
  );

        }
        public void Delete()
        {
            DalBase.Contact_Delete(CntID);
        }
        public List<Contact> Retrieve(int Filter)
        {
            return
            DalBase.Contact_Retrieve(

          Filter
 , CntID
 , CntFullName
 , CntMobile
 , CntMessage
 , CntDT
 ).ToList<Contact>();

        }
    }
}
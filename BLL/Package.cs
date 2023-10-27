using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;

namespace mhmdhidry.BLL
{
    public class Package
    {

        private DAL.Base DalBase = new DAL.Base();

        public Package()
        {

        }


        public int PkgId { get; set; }

        public string Pkg_Name { get; set; }

        public int Pkg_Dur { get; set; }

        public string Pkg_Teacher { get; set; }

        public DateTime Pkg_date { get; set; }
        public decimal Pkg_Price { get; set; }
        public string dsc { get; set; }
        public string Pkg_Pic { get; set; }
        public string status { get; set; }

		public string Pkg_tag { get; set; }
		public string Pkg_more_dsc { get; set; }
		public string Pkg_cat { get; set; }




		public List<Package> Insert()
        {
            return
            DalBase.Package_Insert(

            PkgId
  ,  Pkg_Name
,  Pkg_Dur
,  Pkg_Teacher
,  Pkg_date
,  Pkg_Price

,  dsc
,  Pkg_Pic
,  status
,
		  Pkg_tag,
		  Pkg_more_dsc,
		  Pkg_cat
  ).ToList<Package>();

        }

        public void Update(int Filter)
        {
            DalBase.Package_Update(

           Filter
  , PkgId
  , Pkg_Name
, Pkg_Dur
, Pkg_Teacher
, Pkg_date
, Pkg_Price

, dsc
, Pkg_Pic
, status
,
		  Pkg_tag,
		  Pkg_more_dsc,
		  Pkg_cat
  );

        }
        public void Delete()
        {
            DalBase.Package_Delete(PkgId);
        }
        public List<Package> Retrieve(int Filter)
        {
            return
            DalBase.Package_Retrieve(

          Filter
 ,  PkgId
,  Pkg_Name
,  Pkg_Dur
,  Pkg_Teacher
,  Pkg_date
,  Pkg_Price

,  dsc
,  Pkg_Pic
,  status
,
		  Pkg_tag,
		  Pkg_more_dsc,
		  Pkg_cat
 ).ToList<Package>();

        }
    }
}
using System.Data;

namespace mhmdhidry.BLL
{
    public class Subscribe
    {

        private DAL.Base DalBase = new DAL.Base();

        public Subscribe()
        {

        }


        public int SbcID { get; set; }

        public string SbcMobile { get; set; }

        public string SbcSource { get; set; }

        public DateTime SbcDT { get; set; }


        public List<Subscribe> Insert()
        {
            return
            DalBase.Subscribe_Insert(

            SbcID
  , SbcMobile
  , SbcSource
  , SbcDT
  ).ToList<Subscribe>();

        }

        public void Update(int Filter)
        {
            DalBase.Subscribe_Update(

           Filter
  , SbcID
  , SbcMobile
  , SbcSource
  , SbcDT
  );

        }
        public void Delete()
        {
            DalBase.Subscribe_Delete(SbcID);
        }
        public List<Subscribe> Retrieve(int Filter)
        {
            return
            DalBase.Subscribe_Retrieve(

          Filter
 , SbcID
 , SbcMobile
 , SbcSource
 , SbcDT
 ).ToList<Subscribe>();

        }
    }
}
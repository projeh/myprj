using System.ComponentModel.DataAnnotations;

namespace mhmdhidry.BLL
{
    public class Users
    {

        private DAL.Base DalBase = new DAL.Base();

        public Users()
        {
        }

        public int Filter { get; set; }

        [Display(Name = "کد")]
        public int UsrID { get; set; }

        [Required(ErrorMessage = "لطفا نام کاربری را وارد کنید")]
        [Display(Name = "نام کاربری")]
        public string UsrName { get; set; }

        [Required(ErrorMessage = "لطفا رمز عبور را وارد کنید")]
        [Display(Name = "رمز عبور")]
        public string UsrPass { get; set; }

        [Required(ErrorMessage = "لطفا نام و نام خانوادگی را وارد کنید")]
        [Display(Name = "نام و نام خانوادگی")]
        public string UsrDesc { get; set; }

        public bool UsrIsActive { get; set; }

        public bool UsrIsAdmin { get; set; }

        [Display(Name = "تاریخ")]
        public DateTime UsrDT { get; set; }

        [Required(ErrorMessage = "لطفا شماره همراه را وارد کنید")]
        [Display(Name = "شماره همراه")]
        public string UsrMobile { get; set; }

        public string UsrCode { get; set; }
                
        public List<Users> Insert()
        {
            return
            DalBase.Users_Insert(
    UsrID
, UsrName
, UsrPass
, UsrDesc
, UsrIsActive
, UsrIsAdmin
, UsrDT
, UsrMobile
, UsrCode
  ).ToList<Users>();

        }

        public void Update()
        {
            DalBase.Users_Update(

  Filter
, UsrID
, UsrName
, UsrPass
, UsrDesc
, UsrIsActive
, UsrIsAdmin
, UsrDT
, UsrMobile
, UsrCode
  );

        }
        public void Delete()
        {
            DalBase.Users_Delete(UsrID);
        }
        public List<Users> Retrieve()
        {
            return
            DalBase.Users_Retrieve(

 Filter
, UsrID
, UsrName
, UsrPass
, UsrDesc
, UsrIsActive
, UsrIsAdmin
, UsrDT
, UsrMobile
, UsrCode
 ).ToList<Users>();

        }
    }
}
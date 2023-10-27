using Microsoft.AspNetCore.DataProtection.KeyManagement;
using System.Data;
using System.Data.SqlClient;
namespace mhmdhidry.DAL
{
    public class Base
    {
        #region private Variable
        private SqlConnection Con;
        private string StrCon = Share.GetConnectionString();
        #endregion

        #region Constructor
        public Base()
        {

        }
        #endregion

        #region Function

        #region Contact
        public DataTable Contact_Insert(

         int CntID
, string CntFullName
, string CntMobile
, string CntMessage
, DateTime CntDT
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Contact_Insert", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@CntID", SqlDbType.Int).Value = CntID;
                if (CntFullName == null)
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = CntFullName;
                if (CntMobile == null)
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = CntMobile;
                if (CntMessage == null)
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = CntMessage;
                if (CntDT == default)
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = CntDT;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }
            }
        }
        public void Contact_Update(

        int Filter
, int CntID
, string CntFullName
, string CntMobile
, string CntMessage
, DateTime CntDT
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Contact_Update", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@CntID", SqlDbType.Int).Value = CntID;
                if (CntFullName == null)
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = CntFullName;
                if (CntMobile == null)
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = CntMobile;
                if (CntMessage == null)
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = CntMessage;
                if (CntDT == default)
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = CntDT;

                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public void Contact_Delete(long CntID)
        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Contact_Delete", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@CntID", SqlDbType.BigInt).Value = CntID;
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public DataTable Contact_Retrieve(

        int Filter
, int CntID
, string CntFullName
, string CntMobile
, string CntMessage
, DateTime CntDT
)

        {

            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Contact_Retrieve", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@CntID", SqlDbType.Int).Value = CntID;
                if (CntFullName == null)
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntFullName", SqlDbType.NVarChar).Value = CntFullName;
                if (CntMobile == null)
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMobile", SqlDbType.NVarChar).Value = CntMobile;
                if (CntMessage == null)
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntMessage", SqlDbType.NVarChar).Value = CntMessage;
                if (CntDT == default)
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@CntDT", SqlDbType.DateTime).Value = CntDT;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }


            }
        }

        #endregion

        #region CoursRegister
        public DataTable CoursRegister_Insert(

		 int CrgID
, string CrgFullName
, string CrgMobile
, DateTime CrgDT
, string CrgLndCode
, string CrgSecurityCode
)

		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("CoursRegister_Insert", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@CrgID", SqlDbType.Int).Value = CrgID;
				if (CrgFullName == null)
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = CrgFullName;
				if (CrgMobile == null)
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = CrgMobile;
				if (CrgDT == default)
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = CrgDT;
				if (CrgLndCode == null)
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = CrgLndCode;
				if (CrgSecurityCode == null)
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = CrgSecurityCode;

				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
				{
					DataTable DT = new DataTable();
					DA.Fill(DT);
					Con.Close();
					return DT;
				}
			}
		}
		public void CoursRegister_Update(

		int Filter
, int CrgID
, string CrgFullName
, string CrgMobile
, DateTime CrgDT
, string CrgLndCode
, string CrgSecurityCode
)

		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("CoursRegister_Update", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@CrgID", SqlDbType.Int).Value = CrgID;
				if (CrgFullName == null)
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = CrgFullName;
				if (CrgMobile == null)
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = CrgMobile;
				if (CrgDT == default)
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = CrgDT;
				if (CrgLndCode == null)
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = CrgLndCode;
				if (CrgSecurityCode == null)
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = CrgSecurityCode;

				try
				{
					Cmd.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{

				}
				Con.Close();
			}
		}
		public void CoursRegister_Delete(long CrgID)
		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("CoursRegister_Delete", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@CrgID", SqlDbType.BigInt).Value = CrgID;
				try
				{
					Cmd.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{

				}
				Con.Close();
			}
		}
		public DataTable CoursRegister_Retrieve(

		int Filter
, int CrgID
, string CrgFullName
, string CrgMobile
, DateTime CrgDT
, string CrgLndCode
, string CrgSecurityCode
)

		{

			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("CoursRegister_Retrieve", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@CrgID", SqlDbType.Int).Value = CrgID;
				if (CrgFullName == null)
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgFullName", SqlDbType.NVarChar).Value = CrgFullName;
				if (CrgMobile == null)
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgMobile", SqlDbType.NVarChar).Value = CrgMobile;
				if (CrgDT == default)
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgDT", SqlDbType.DateTime).Value = CrgDT;
				if (CrgLndCode == null)
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgLndCode", SqlDbType.NVarChar).Value = CrgLndCode;
				if (CrgSecurityCode == null)
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@CrgSecurityCode", SqlDbType.NVarChar).Value = CrgSecurityCode;

				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
				{
					DataTable DT = new DataTable();
					DA.Fill(DT);
					Con.Close();
					return DT;
				}


			}
		}

        #endregion




        #region Package
        public DataTable Package_Insert(

         int PkgId
, string Pkg_Name
, int Pkg_Dur
, string Pkg_Teacher
, DateTime Pkg_date
,decimal Pkg_Price

, string dsc
, string Pkg_Pic
, string status,
		 string Pkg_tag,
		 string Pkg_more_dsc,
		 string Pkg_cat

		 )

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("pkg_Insert", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@PkgId", SqlDbType.Int).Value = PkgId;
                if (Pkg_Name == null)
                    Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = Pkg_Name;
                if (Pkg_Teacher == null)
                    Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = Pkg_Teacher;
                if (dsc == null)
                    Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = dsc;
                if (Pkg_date == default)
                    Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = Pkg_date;
				if (Pkg_Dur == default)
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = Pkg_Dur;
				if (Pkg_Price == default)
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = Pkg_Price;

				if (status == null)
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;


				if (Pkg_Pic == null)
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = Pkg_Pic;

				if (Pkg_tag == null)
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = Pkg_tag;

				if (Pkg_more_dsc == null)
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = Pkg_more_dsc;

				if (Pkg_cat == null)
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = Pkg_cat;


				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }
            }
        }
        public void Package_Update(

        int Filter
, int PkgId
, string Pkg_Name
, int Pkg_Dur
, string Pkg_Teacher
, DateTime Pkg_date
, decimal Pkg_Price

, string dsc
, string Pkg_Pic
, string status
			,
		 string Pkg_tag,
		 string Pkg_more_dsc,
		 string Pkg_cat
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Package_Update", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@PkgId", SqlDbType.Int).Value = PkgId;
				if (Pkg_Name == null)
					Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = Pkg_Name;
				if (Pkg_Teacher == null)
					Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = Pkg_Teacher;
				if (dsc == null)
					Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = dsc;
				if (Pkg_date == default)
					Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = Pkg_date;
				if (Pkg_Dur == default)
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = Pkg_Dur;
				if (Pkg_Price == default)
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = Pkg_Price;

				if (status == null)
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;


				if (Pkg_Pic == null)
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = Pkg_Pic;
				if (Pkg_tag == null)
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = Pkg_tag;

				if (Pkg_more_dsc == null)
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = Pkg_more_dsc;

				if (Pkg_cat == null)
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = Pkg_cat;



				try
				{
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public void Package_Delete(long CntID)
        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Package_Delete", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@CntID", SqlDbType.BigInt).Value = CntID;
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public DataTable Package_Retrieve(

        int Filter
, int PkgId
, string Pkg_Name
, int Pkg_Dur
, string Pkg_Teacher
, DateTime Pkg_date
, decimal Pkg_Price

, string dsc
, string Pkg_Pic
, string status
			,
		 string Pkg_tag,
		 string Pkg_more_dsc,
		 string Pkg_cat
)

        {

            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Pkg_Retrieve", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@PkgId", SqlDbType.Int).Value = PkgId;
				if (Pkg_Name == null)
					Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Name", SqlDbType.NVarChar).Value = Pkg_Name;
				if (Pkg_Teacher == null)
					Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Teacher", SqlDbType.NVarChar).Value = Pkg_Teacher;
				if (dsc == null)
					Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@dsc", SqlDbType.NVarChar).Value = dsc;
				if (Pkg_date == default)
					Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_date", SqlDbType.DateTime).Value = Pkg_date;
				if (Pkg_Dur == default)
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Dur", SqlDbType.Int).Value = Pkg_Dur;
				if (Pkg_Price == default)
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = 0;
				else
					Cmd.Parameters.Add("@Pkg_Price", SqlDbType.Decimal).Value = Pkg_Price;

				if (status == null)
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@status", SqlDbType.NVarChar).Value = status;


				if (Pkg_Pic == null)
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_Pic", SqlDbType.NVarChar).Value = Pkg_Pic;

				if (Pkg_tag == null)
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_tag", SqlDbType.NVarChar).Value = Pkg_tag;

				if (Pkg_more_dsc == null)
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_more_dsc", SqlDbType.NVarChar).Value = Pkg_more_dsc;

				if (Pkg_cat == null)
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@Pkg_cat", SqlDbType.NVarChar).Value = Pkg_cat;


				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }


            }
        }

        #endregion




        #region Landings
        public DataTable Landings_Insert(

		 int LndID
, string LndTitle
, string LndCode
, string LndDesc
, string LndPoster
, string LndVideo
, DateTime LndDT
, string LndSuccessMessage
, string LndSmsMessage
)

		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("Landings_Insert", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@LndID", SqlDbType.Int).Value = LndID;
				if (LndTitle == null)
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = LndTitle;
				if (LndCode == null)
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = LndCode;
				if (LndDesc == null)
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = LndDesc;
				if (LndPoster == null)
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = LndPoster;
				if (LndVideo == null)
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = LndVideo;
				if (LndDT == default)
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = LndDT;
				if (LndSuccessMessage == null)
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = LndSuccessMessage;
				if (LndSmsMessage == null)
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = LndSmsMessage;

				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
				{
					DataTable DT = new DataTable();
					DA.Fill(DT);
					Con.Close();
					return DT;
				}
			}
		}
		public void Landings_Update(

		int Filter
, int LndID
, string LndTitle
, string LndCode
, string LndDesc
, string LndPoster
, string LndVideo
, DateTime LndDT
, string LndSuccessMessage
, string LndSmsMessage
)

		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("Landings_Update", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@LndID", SqlDbType.Int).Value = LndID;
				if (LndTitle == null)
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = LndTitle;
				if (LndCode == null)
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = LndCode;
				if (LndDesc == null)
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = LndDesc;
				if (LndPoster == null)
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = LndPoster;
				if (LndVideo == null)
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = LndVideo;
				if (LndDT == default)
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = LndDT;
				if (LndSuccessMessage == null)
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = LndSuccessMessage;
				if (LndSmsMessage == null)
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = LndSmsMessage;

				try
				{
					Cmd.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{

				}
				Con.Close();
			}
		}
		public void Landings_Delete(long LndID)
		{
			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("Landings_Delete", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@LndID", SqlDbType.BigInt).Value = LndID;
				try
				{
					Cmd.ExecuteNonQuery();
				}
				catch (SqlException ex)
				{

				}
				Con.Close();
			}
		}
		public DataTable Landings_Retrieve(

		int Filter
, int LndID
, string LndTitle
, string LndCode
, string LndDesc
, string LndPoster
, string LndVideo
, DateTime LndDT
, string LndSuccessMessage
, string LndSmsMessage
)

		{

			using (Con = new SqlConnection(StrCon))
			{
				Con.Open();
				SqlCommand Cmd = new SqlCommand("Landings_Retrieve", Con);
				Cmd.CommandType = CommandType.StoredProcedure;
				Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
				Cmd.Parameters.Add("@LndID", SqlDbType.Int).Value = LndID;
				if (LndTitle == null)
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndTitle", SqlDbType.NVarChar).Value = LndTitle;
				if (LndCode == null)
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndCode", SqlDbType.NVarChar).Value = LndCode;
				if (LndDesc == null)
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDesc", SqlDbType.NVarChar).Value = LndDesc;
				if (LndPoster == null)
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndPoster", SqlDbType.NVarChar).Value = LndPoster;
				if (LndVideo == null)
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndVideo", SqlDbType.NVarChar).Value = LndVideo;
				if (LndDT == default)
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndDT", SqlDbType.DateTime).Value = LndDT;
				if (LndSuccessMessage == null)
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSuccessMessage", SqlDbType.NVarChar).Value = LndSuccessMessage;
				if (LndSmsMessage == null)
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = DBNull.Value;
				else
					Cmd.Parameters.Add("@LndSmsMessage", SqlDbType.NVarChar).Value = LndSmsMessage;

				using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
				{
					DataTable DT = new DataTable();
					DA.Fill(DT);
					Con.Close();
					return DT;
				}


			}
		}

		#endregion

		#region Subscribe
		public DataTable Subscribe_Insert(

         int SbcID
, string SbcMobile
, string SbcSource
, DateTime SbcDT
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Subscribe_Insert", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@SbcID", SqlDbType.Int).Value = SbcID;
                if (SbcMobile == null)
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = SbcMobile;
                if (SbcSource == null)
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = SbcSource;
                if (SbcDT == default)
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = SbcDT;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }
            }
        }
        public void Subscribe_Update(

        int Filter
, int SbcID
, string SbcMobile
, string SbcSource
, DateTime SbcDT
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Subscribe_Update", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@SbcID", SqlDbType.Int).Value = SbcID;
                if (SbcMobile == null)
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = SbcMobile;
                if (SbcSource == null)
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = SbcSource;
                if (SbcDT == default)
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = SbcDT;

                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public void Subscribe_Delete(long SbcID)
        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Subscribe_Delete", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@SbcID", SqlDbType.BigInt).Value = SbcID;
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public DataTable Subscribe_Retrieve(

        int Filter
, int SbcID
, string SbcMobile
, string SbcSource
, DateTime SbcDT
)

        {

            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Subscribe_Retrieve", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@SbcID", SqlDbType.Int).Value = SbcID;
                if (SbcMobile == null)
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcMobile", SqlDbType.NVarChar).Value = SbcMobile;
                if (SbcSource == null)
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcSource", SqlDbType.NVarChar).Value = SbcSource;
                if (SbcDT == default)
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@SbcDT", SqlDbType.DateTime).Value = SbcDT;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }


            }
        }

        #endregion

        #region Users
        public DataTable Users_Insert(

         int UsrID
, string UsrName
, string UsrPass
, string UsrDesc
, bool UsrIsActive
, bool UsrIsAdmin
, DateTime UsrDT
, string UsrMobile
, string UsrCode
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Users_Insert", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@UsrID", SqlDbType.Int).Value = UsrID;
                if (UsrName == null)
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = UsrName;
                if (UsrPass == null)
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = UsrPass;
                if (UsrDesc == null)
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = UsrDesc;
				Cmd.Parameters.Add("@UsrIsActive", SqlDbType.Bit).Value = UsrIsActive;
				Cmd.Parameters.Add("@UsrIsAdmin", SqlDbType.Bit).Value = UsrIsAdmin;
				if (UsrDT == default)
                    Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = UsrDT;
                if (UsrMobile == null)
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = UsrMobile;
                if (UsrCode == null)
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = UsrCode;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }
            }
        }
        public void Users_Update(

        int Filter
, int UsrID
, string UsrName
, string UsrPass
, string UsrDesc
, bool UsrIsActive
, bool UsrIsAdmin
, DateTime UsrDT
, string UsrMobile
, string UsrCode
)

        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Users_Update", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@UsrID", SqlDbType.Int).Value = UsrID;
                if (UsrName == null)
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = UsrName;
                if (UsrPass == null)
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = UsrPass;
                if (UsrDesc == null)
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = UsrDesc;
				Cmd.Parameters.Add("@UsrIsActive", SqlDbType.Bit).Value = UsrIsActive;
				Cmd.Parameters.Add("@UsrIsAdmin", SqlDbType.Bit).Value = UsrIsAdmin;
				if (UsrDT == default)
					Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = UsrDT;
                if (UsrMobile == null)
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = UsrMobile;
                if (UsrCode == null)
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = UsrCode;

                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public void Users_Delete(long UsrID)
        {
            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Users_Delete", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@UsrID", SqlDbType.BigInt).Value = UsrID;
                try
                {
                    Cmd.ExecuteNonQuery();
                }
                catch (SqlException ex)
                {

                }
                Con.Close();
            }
        }
        public DataTable Users_Retrieve(

        int Filter
, int UsrID
, string UsrName
, string UsrPass
, string UsrDesc
, bool UsrIsActive
, bool UsrIsAdmin
, DateTime UsrDT
, string UsrMobile
, string UsrCode
)

        {

            using (Con = new SqlConnection(StrCon))
            {
                Con.Open();
                SqlCommand Cmd = new SqlCommand("Users_Retrieve", Con);
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.Add("@Filter", SqlDbType.Int).Value = Filter;
                Cmd.Parameters.Add("@UsrID", SqlDbType.Int).Value = UsrID;
                if (UsrName == null)
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrName", SqlDbType.NVarChar).Value = UsrName;
                if (UsrPass == null)
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrPass", SqlDbType.NVarChar).Value = UsrPass;
                if (UsrDesc == null)
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDesc", SqlDbType.NVarChar).Value = UsrDesc;
				Cmd.Parameters.Add("@UsrIsActive", SqlDbType.Bit).Value = UsrIsActive;
				Cmd.Parameters.Add("@UsrIsAdmin", SqlDbType.Bit).Value = UsrIsAdmin;
				if (UsrDT == default)
					Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrDT", SqlDbType.DateTime).Value = UsrDT;
                if (UsrMobile == null)
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrMobile", SqlDbType.VarChar).Value = UsrMobile;
                if (UsrCode == null)
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = DBNull.Value;
                else
                    Cmd.Parameters.Add("@UsrCode", SqlDbType.VarChar).Value = UsrCode;

                using (SqlDataAdapter DA = new SqlDataAdapter(Cmd))
                {
                    DataTable DT = new DataTable();
                    DA.Fill(DT);
                    Con.Close();
                    return DT;
                }


            }
        }

        #endregion

        #endregion
    }
}
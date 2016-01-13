using DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BLL
{
  public  class BLLCustomerDetails
    {
        public int InsertIntoCustomersDetails(string new_customer_id, string customer_id, string title, string name, string spouse, string adress , string birthdate, string anniversary , int phone, int mobile, int fax, string email, string city)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@new_customer_id",new_customer_id),
                    new SqlParameter("@customer_id",customer_id),
                    new SqlParameter("@title",title),
                    new SqlParameter("@name",name),
                    new SqlParameter("@spouse",spouse),
                    new SqlParameter("@adress",adress),
                    new SqlParameter("@birthdate",birthdate),
                    new SqlParameter("@anniversary",anniversary),
                    new SqlParameter("@phone",phone),
                    new SqlParameter("@mobile",mobile),
                    new SqlParameter("@fax",fax),
                    new SqlParameter("@email",email),
                    new SqlParameter("@city",city)


                };
            //inserting into customer details table by parameter
             
            return DOA.IDU("insert into `tbl_customer_details`(new_customer_id,customer_id,title,name,spouse,adress,birthdate,anniversary,phone,mobile,fax,email,city ) values(@new_customer_id,@customer_id,@title,@name,@spouse,@adress,@birthdate,@anniversary,@phone,@mobile,@fax,@email,@city )", parm);
        }

        public DataTable Fectching_All_Table_data()
        {
            DataTable dt = new DataTable();
            return DOA.getdata("select * from tbl_customer_details", null);
        }
    }


}


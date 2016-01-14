using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    class BLLSupplier_details
    {
        public int InsertIntoSupplierDetails(int supplier_id,string supplier_type , int new_supplier_id, string title, string name,  int contact, string adress ,int phone, int mobile, int fax, string email, string city, int ecc_no, int cst_no, string division, int pan_no)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@supplier_id",supplier_id),
                     new SqlParameter("@supplier_type",supplier_type),
                      new SqlParameter("@new_supplier_id",new_supplier_id),
                       new SqlParameter("@title",title),
                        new SqlParameter("@name",name),
                         new SqlParameter("@contact",contact),
                          new SqlParameter("@adress",adress),
                           new SqlParameter("@phone",phone),
                            new SqlParameter("@mobile",mobile),
                             new SqlParameter("@fax",fax),
                              new SqlParameter("@email",email),
                               new SqlParameter("@city",city),
                               new SqlParameter("@ecc_no",ecc_no),
                                new SqlParameter("@cst_no",cst_no),
                                    new SqlParameter("@division",division),
                                        new SqlParameter("@pan_no",pan_no)

                };
            //inserting into suppliers details table by parameter

            return DOA.IDU("insert into tbl_supplier_details values(@supplier_id,@supplier_type ,@new_supplier_id, @title, @name,  @contact, @adress ,@phone, @mobile, @fax, @email, @city,@ecc_no, @cst_no, @division, @pan_no)", parm);
        }

    }
}

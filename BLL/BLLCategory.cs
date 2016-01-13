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
  public  class BLLCategory
    {
        
        //add new category 
        public int addnewcategory(string category_name)
        {
            SqlParameter[] parm = new SqlParameter[]
                {
                    new SqlParameter("@category_name",category_name)
                };
            return DOA.IDU("insert into tbl_category values(@category_name)", parm);
        }
        //take all data from database
        public DataTable getalldata()
        {
            DataTable dt = new DataTable();
            return DOA.getdata("select * from tbl_category", null);
        }
    }
}

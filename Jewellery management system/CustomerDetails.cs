using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace Jewellery_management_system
{
    public partial class CustomerDetails : Form
    {
        public CustomerDetails()
        {
            InitializeComponent();
        }


        BLLCustomerDetails cusdetail = new BLLCustomerDetails();
        private void btn_save_Click(object sender, EventArgs e)
        {
            //string new_customer_id, string customer_id, string title, string name, string spouse, string adress, string birthdate, string anniversary, int phone, int mobile, int fax, string email, string city
            int InsertValuetoCustomerDetailsTable = cusdetail.InsertIntoCustomersDetails(txt_newCustomerID.Text,cbo_customerId.Text,cbo_title.Text,cbo_name.Text,txt_spouse.Text,txt_adress.Text,dtp_birthdate.Text,dtp_anniversary.Text, Convert.ToInt32(txt_phone.Text), Convert.ToInt32(txt_mobile.Text),Convert.ToInt32(txt_fax.Text),txt_email.Text,txt_city.Text);
            if (InsertValuetoCustomerDetailsTable > 0) {
                MessageBox.Show("Data Inserted");
            }
            else {
                MessageBox.Show("error While inserting Data");
            }
        }
    }
}

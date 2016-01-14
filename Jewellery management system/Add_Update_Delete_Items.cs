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
    public partial class Add_Update_Delete_Items : Form
    {
        public Add_Update_Delete_Items()
        {
            InitializeComponent();
        }
        BLLItem_Add_Update biau = new BLLItem_Add_Update();
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Update_Delete_Items_Load(object sender, EventArgs e)
        {
            DataTable dt = biau.FetchAllData();
            if (dt.Rows.Count > 0)
            {
                ADU_dataGridView.DataSource = dt;
            }

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            //int syn_no,int barcode,string category,string item,decimal cost_price, decimal sell_price, decimal mark_price,int unit,int stock, int minimum, int maximum

            int i = biau.InsertIntoTable(Convert.ToInt32(cbo_syn.Text),Convert.ToInt32(txt_barcode.Text),cbo_category.Text,cbo_item.Text, Convert.ToDecimal(txt_cost_price.Text),Convert.ToDecimal(txt_sell_price.Text),Convert.ToDecimal(txt_martket_price.Text), Convert.ToInt32(cbo_unit.Text),Convert.ToInt32(txt_stock.Text),Convert.ToInt32(txt_min.Text),Convert.ToInt32(txt_max.Text));
            if (i>0) {
                MessageBox.Show("data inserted successfully");
            }
        }

        private void ADU_dataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            Add_Update_Delete_Items_update up = new Add_Update_Delete_Items_update();
            up.cbo_syn.Text = Convert.ToInt32(ADU_dataGridView.CurrentRow.Cells[0].Value).ToString();
           //reamaining 
          

            up.Show();
        }
    }
}

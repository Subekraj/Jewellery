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
    public partial class Account_and_journal_entry : Form
    {
        public Account_and_journal_entry()
        {
            InitializeComponent();
        }
        BLLAccounts_Journal_entry aje = new BLLAccounts_Journal_entry();

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            ClearAllText(this);
            ClearAllcboitem(this);
            Cleardate(this);
           
        }

        public void ClearAllText(Control con)//to clear all the text in the textboxes

        {
            foreach (Control c in con.Controls)
            {
                if (c is TextBox)
                    ((TextBox)c).Clear();
                else
                    ClearAllText(c);
            }
        }
        //to clear all the texts in combo box
        public void ClearAllcboitem(Control con) {
            foreach (Control c in con.Controls)
            {
                if (c is ComboBox)
                    ((ComboBox)c).ResetText();
                else
                    ClearAllcboitem(c);
            }

        }

        public void Cleardate(Control con)//clearing the setted date into current date
        {
            foreach (Control c in con.Controls)
            {
                if (c is DateTimePicker)
                    ((DateTimePicker)c).ResetText();
                else
                    Cleardate(c);
            }

        }


        private void txt_new_id_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            int insert = aje.InsertIntoTable(Convert.ToDateTime(dtp_date.Text), cbo_voucher_type.Text, Convert.ToInt32(txt_new_id.Text), Convert.ToInt32(cbo_existing_vid.Text), cbo_ac_name.Text, cbo_dr_cr.Text, Convert.ToDecimal(txt_amount.Text), Convert.ToDecimal(txt_debit.Text), Convert.ToDecimal(txt_credit.Text));
            if (insert > 0)
            {
                MessageBox.Show("data inserted...");
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        { int s = 1;
            if (cbo_voucher_type.Text == "" || txt_new_id.Text == "" || cbo_existing_vid.Text == "" || cbo_existing_vid.Text == "" || cbo_ac_name.Text == "" || txt_amount.Text == "" || txt_narration.Text == "")
            {
                MessageBox.Show("the input are empty..");
            }
            else
            {
               // dataGridView_adddata.Rows.Add(); // value not passsing her efro text box to datagrid view 
                dataGridView_adddata.Rows[s].Cells["date"].Value = dtp_date.ToString();
                dataGridView_adddata.Rows[s].Cells["voucher_type"].Value = cbo_voucher_type.Text;
                dataGridView_adddata.Rows[s].Cells["account_name"].Value = cbo_ac_name.Text;
                dataGridView_adddata.Rows[s].Cells["dr_cr"].Value = cbo_dr_cr.Text;
                dataGridView_adddata.Rows[s].Cells["amount"].Value = txt_amount.Text;
                dataGridView_adddata.Rows[s].Cells["narration"].Value = txt_narration.Text;
                dataGridView_adddata.Rows[s].Cells["debit"].Value = txt_debit.Text;
                dataGridView_adddata.Rows[s].Cells["credit"].Value = txt_credit.Text;
                s++;
            }
        }

        private void dataGridView_adddata_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // account_journal_entry_update ajeu = new account_journal_entry_update();
            //ajeu.dtp_date.Text = Convert.ToDateTime(dataGridView_adddata.CurrentRow.Cells[0].Value).ToString();

            dtp_date.Text = dataGridView_adddata.CurrentRow.Cells[0].Value.ToString();
           cbo_voucher_type.Text = dataGridView_adddata.CurrentRow.Cells[1].Value.ToString();
          txt_new_id.Text = dataGridView_adddata.CurrentRow.Cells[2].Value.ToString();
           cbo_existing_vid.Text =dataGridView_adddata.CurrentRow.Cells[3].Value.ToString();
            cbo_ac_name.Text = dataGridView_adddata.CurrentRow.Cells[4].Value.ToString();
            cbo_dr_cr.Text = dataGridView_adddata.CurrentRow.Cells[5].Value.ToString();
            txt_amount.Text = dataGridView_adddata.CurrentRow.Cells[6].Value.ToString();
            txt_narration.Text = dataGridView_adddata.CurrentRow.Cells[7].Value.ToString();
       
        }
        
    }
    }


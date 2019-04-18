using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace CMS_DB_Project
{
    public partial class frm_manage_donor : Form
    {
        string connectionData = "Data Source=orcl; User Id=hr; Password=hr";
        OracleConnection connection;

        public frm_manage_donor()
        {
            InitializeComponent();
        }

        
        /// <summary>
        /// Form Event and GUI help Functions
        /// </summary>

        private void frm_manage_donor_Load(object sender, EventArgs e)
        {
            getDonors();

            donors_table.Columns[0].HeaderText = "Email";
            donors_table.Columns[1].HeaderText = "First Name";
            donors_table.Columns[2].HeaderText = "Last Name";
            donors_table.Columns[3].HeaderText = "Mobile";
            donors_table.Columns[4].HeaderText = "Address";

            updateTextBox();
        }
        private void donors_table_MouseClick(object sender, MouseEventArgs e)
        {
            txt_email.Text = donors_table.SelectedRows[0].Cells[0].Value.ToString();
            txt_fname.Text = donors_table.SelectedRows[0].Cells[1].Value.ToString();
            txt_lname.Text = donors_table.SelectedRows[0].Cells[2].Value.ToString();
            txt_mobile.Text = donors_table.SelectedRows[0].Cells[3].Value.ToString();
            txt_address.Text = donors_table.SelectedRows[0].Cells[4].Value.ToString();
        }


        /// <summary>
        /// Buttons Events Insert, Save, Cancel, Delete, Update.
        /// </summary>

        private void btn_insert_Click(object sender, EventArgs e)
        {
            btn_save.Visible = true;
            btn_cancel.Visible = true;

            txt_email.Text = "";
            txt_fname.Text = "";
            txt_lname.Text = "";
            txt_mobile.Text = "";
            txt_address.Text = "";

        }
        private void btn_save_Click(object sender, EventArgs e)
        {
            insertDonor(txt_email.Text, txt_fname.Text, txt_lname.Text,
                        txt_mobile.Text, txt_address.Text);

            lable_messege.Visible = true;
            lable_messege.Text = "Messege : Row Inserted Sucessfully.";
            lable_messege.ForeColor = Color.Green;

            btn_save.Visible = false;
            btn_cancel.Visible = false;

            donors_table.Controls.Clear();
            getDonors();
            return;
        }
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            btn_save.Visible = false;
            btn_cancel.Visible = false;
            updateTextBox();
        }
        private void btn_delete_Click(object sender, EventArgs e)
        {
            int numberOfDonations = cheakDonations(txt_email.Text);

            if(numberOfDonations > 0)
            {
                DialogResult res =  MessageBox.Show("This donor has made many donations. Would you like to delete the records?",
                    "Donations", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    deleteDonations(txt_email.Text);
                }
                else
                    return;
            }

            deleteDonor(txt_email.Text);

            lable_messege.Visible = true;
            lable_messege.Text = "Messege : Row Deleted Sucessfully.";
            lable_messege.ForeColor = Color.Green;

            donors_table.Controls.Clear();
            getDonors();

            updateTextBox();

            return;
        }
        private void btn_update_Click(object sender, EventArgs e)
        {
            updateDonor(txt_email.Text, txt_fname.Text, txt_lname.Text,
                        txt_mobile.Text, txt_address.Text);

            lable_messege.Visible = true;
            lable_messege.Text = "Messege : Row Updated Sucessfully.";
            lable_messege.ForeColor = Color.Green;

            donors_table.Controls.Clear();
            getDonors();

            return;
        }

        /// <summary>
        /// API Help Functions.
        ///     1) getDonor -> Dissconnected Mode
        ///     2) deleteDonor -> Connected Mode
        ///     3) updateDonor -> Connected Mode
        ///     4) insertDonor -> Connected Mode
        /// </summary>
        
        public void updateTextBox()
        {
            txt_email.Text = donors_table.Rows[0].Cells[0].Value.ToString();
            txt_fname.Text = donors_table.Rows[0].Cells[1].Value.ToString();
            txt_lname.Text = donors_table.Rows[0].Cells[2].Value.ToString();
            txt_mobile.Text = donors_table.Rows[0].Cells[3].Value.ToString();
            txt_address.Text = donors_table.Rows[0].Cells[4].Value.ToString();

            return;
        }

        public void getDonors()
        {
            string selectCommand = "select * from donor";
            OracleDataAdapter adapter = new OracleDataAdapter(selectCommand, connectionData);
            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);
            donors_table.DataSource = dataSet.Tables[0];
            return;
        }

        public void deleteDonor(string _email)
        {
            connection = new OracleConnection(connectionData);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Delete_Donor";
            cmd.Parameters.Add("Email", _email);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void insertDonor(string _email, string _fname, string _lname, 
                                string _mobile, string _address)
        {
            connection = new OracleConnection(connectionData);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Insert_Donor";
            cmd.Parameters.Add("Email", _email);
            cmd.Parameters.Add("Fname", _fname);
            cmd.Parameters.Add("Lname", _lname);
            cmd.Parameters.Add("MobileNum", _mobile);
            cmd.Parameters.Add("Address", _address);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public void updateDonor(string _email, string _fname, string _lname,
                                string _mobile, string _address)
        {
            connection = new OracleConnection(connectionData);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Update_Donor";
            cmd.Parameters.Add("Email", _email);
            cmd.Parameters.Add("Fname", _fname);
            cmd.Parameters.Add("Lname", _lname);
            cmd.Parameters.Add("MobileNum", _mobile);
            cmd.Parameters.Add("Address", _address);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        public int cheakDonations(string _email)
        {
            connection = new OracleConnection(connectionData);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "select * from DONATESFOR where DONOREMAIL=:n";
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.Add("n", _email);

            int numberOfDonations = 0;
            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                numberOfDonations++;
            }
            dr.Close();
            return numberOfDonations;
        }

        public void deleteDonations(string _email)
        {
            connection = new OracleConnection(connectionData);
            connection.Open();

            OracleCommand cmd = new OracleCommand();
            cmd.Connection = connection;
            cmd.CommandText = "Delete_Donations";
            cmd.Parameters.Add("Email", _email);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
        }

        
    }
}

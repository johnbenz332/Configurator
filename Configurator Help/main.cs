using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Configurator_Help
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {

        }

        int rdo;
        string SO_total="0";

        private void btn_update_Click(object sender, EventArgs e)
        {
             
        }

        private void rdo_1min_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_1min.Checked == true)
            {
                rdo =0;
            }
            else
            {
                rdo = 1;
            }

            updateSO();
        }

        private void rdo_15min_CheckedChanged(object sender, EventArgs e)
        {
            if (rdo_15min.Checked == true)
            {
                rdo = 1;
            }
            else
            {
                rdo = 0;
            }

            updateSO();
        }

        private void get_SO()
        {
            int vals = Convert.ToInt32(txt_SO.Text);
            string val =Convert.ToString(128 * rdo + vals * 4,16);

            string up = val.ToUpper();

            SO_total = "SO=" + up;
            txt_pfl.Text = "SO=" + up;
        }

        private void updateSO()
        {
            OleDbConnection conn = connectDB.GetConnection();
            try
            {
                string SI = "UPDATE S0 SET S0_speed=@1, SO_E=@2, SO_Total=@3 WHERE ID='001'";

                OleDbCommand cmd1 = new OleDbCommand(SI, conn);
                OleDbParameter param = new OleDbParameter();
                cmd1.Parameters.AddWithValue("@1", txt_SO.Text);
                cmd1.Parameters.AddWithValue("@2", rdo);
                cmd1.Parameters.AddWithValue("@3", SO_total);
                cmd1.ExecuteNonQuery();

                conn.Close();

                get_SO();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txt_SO_TextChanged(object sender, EventArgs e)
        {
            updateSO();
        }

        private void txt_SO_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        //End of S0
        //Start S1

        int S1_val;
        string S1_total = "0";

        private void txt_S1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void updateS1()
        {
            OleDbConnection conn = connectDB.GetConnection();
            try
            {
                string SI = "UPDATE S0 SET S1=@1, S1_Total=@2 WHERE ID='001'";

                OleDbCommand cmd1 = new OleDbCommand(SI, conn);
                OleDbParameter param = new OleDbParameter();
                cmd1.Parameters.AddWithValue("@1", txt_S1.Text);
                cmd1.Parameters.AddWithValue("@2", S1_total);
                cmd1.ExecuteNonQuery();

                conn.Close();

                get_S1();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void get_S1()
        {
            int vals = Convert.ToInt32(txt_S1.Text);
            string val = Convert.ToString(vals/5, 16);

            string up = val.ToUpper();

            S1_total = "S1=" + up;
            txt_pfl.Text = "S1=" + up;
        }

        private void txt_S1_TextChanged(object sender, EventArgs e)
        {
            updateS1();
        }
    }
}

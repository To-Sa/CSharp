using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ACCESS_EXCEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            OleDbConnection excCon = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tetsu\Desktop\ADAT.xlsx; Extended Properties='Excel 12.0;HDR=YES'");

            OleDbCommand excCom = new OleDbCommand("select * from [Munka1$]", excCon);
            excCon.Open();

            OleDbDataAdapter adp = new OleDbDataAdapter(excCom);
            
            adp.Fill(dt);
            dataGridView1.DataSource = dt;

           


            OleDbConnection ca = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tetsu\Desktop\DB.accdb; Jet OLEDB:Database Password=123456;");

            //string str = "update First_Table set USERPASS='"+ txtPW.Text + "' where IDs= " + txtID.Text + "";
            OleDbCommand oca = new OleDbCommand("update adat set FEJLÉC1", ca);
            ca.Open();

            //oca.ExecuteNonQuery();

            /*OleDbDataReader reader1 = oca.ExecuteReader();

            while (reader1.Read())
            {
                listBox1.Items.Add(reader1[1]);
            }*/

            ca.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            int i = 1;
            foreach (DataRow row in dt.Rows)
            {
                try
                {
                    using (OleDbConnection conn = new OleDbConnection())
                    {
                        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tetsu\Desktop\DB.accdb; Jet OLEDB:Database Password=123456;";
                        conn.ConnectionString = connectionString;
                        conn.Open();
                        OleDbCommand command = new OleDbCommand();
                        command.Connection = conn;

                        command.CommandText = @"UPDATE ADAT SET [Fejléc1]=@Fejléc1, 
                                                            [Fejléc2]=@Fejléc2, 
                                                            [Fejléc2]=@Fejléc2, 
                                                            [Fejléc2]=@Fejléc2, 
                                                            [Fejléc3]=@Fejléc3, 
                                                            [Fejléc4]=@Fejléc4,
                                                            [Fejléc5]=@Fejléc5 
                                                      WHERE [Azonosító]=@Azonosító";

                        command.Parameters.AddWithValue("@Fejléc1", row[0]);
                        command.Parameters.AddWithValue("@Fejléc2", row[1]);
                        command.Parameters.AddWithValue("@Fejléc3", row[2]);
                        command.Parameters.AddWithValue("@Fejléc4", row[3]);
                        command.Parameters.AddWithValue("@Fejléc5", row[4]);
                        // Moved after the Cover parameter
                        command.Parameters.AddWithValue("@Azonosító", i);
                        command.ExecuteNonQuery();

                        conn.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("ERROR" + ex);
                }


                listBox1.Items.Add(row[0] + ": " + row[1] + ": " + row[2] + ": " + row[3] + ": " + row[4]);
                i++;

            }
         
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string connstr = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Tetsu\Desktop\DB.accdb;";
            OleDbConnection conn = new OleDbConnection(connstr);
            conn.Open();
            string SQL = string.Format("SELECT * FROM {0}", "ADAT");
            OleDbCommand cmd = new OleDbCommand(SQL, conn);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader != null)
            {
                /*for (int i = 0; i < reader.FieldCount; i++)
                {
                    listBox1.Items.Add(reader.GetName(i));
                }*/

                MessageBox.Show(reader.GetName(0));
            }

            

        }
    }
}

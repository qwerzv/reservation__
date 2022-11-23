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

namespace reserveOfStudyRoom
{
    public partial class 열람실예약 : Form
    {
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;

        public 열람실예약()
        {
            InitializeComponent();
        }

        private void 열람실예약_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "reserve");

                reserveTable = DS.Tables["reserve"];
                DataRow newRow = reserveTable.NewRow();



                DBAdapter.Update(DS, "reserve");
                DS.AcceptChanges();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
        }
    }
}

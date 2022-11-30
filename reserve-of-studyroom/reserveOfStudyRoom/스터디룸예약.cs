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
    public partial class 스터디룸예약 : Form
    {
        //int i;
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;
        public 스터디룸예약()
        {
            
            InitializeComponent();
            this.CenterToScreen();
            DB_Open();

        }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=moonu; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
                string commandString = "select * from room";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }

        }

        private void 스터디룸예약_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            스터디룸 calc = new 스터디룸();
            calc.Show(); // 뒤로가기
            this.Close(); // 창 닫기
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //i++;
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "study");

                reserveTable = DS.Tables["study"];
                DataRow newRow = reserveTable.NewRow();

                //newRow["seq"] = i;
                newRow["room_no"] = roomName.Text;
                newRow["room_time"] = reserveTime.Text;
                newRow["room_status"] = 0;

                reserveTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "study");
                DS.AcceptChanges();
                MessageBox.Show("예약이 되었습니다. \r 스터디룸 : " + roomName.Text + "\r 예약 시간 : " + reserveTime.Text );

                스터디룸 calc = new 스터디룸();
                // calc.btn.Text = "예약중";
                calc.study1_10.Text = "예약중";
                calc.Show(); // 뒤로가기
                this.Close(); // 창 닫기
                
                                

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

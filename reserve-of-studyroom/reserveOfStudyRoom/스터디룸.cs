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
    public partial class 스터디룸 : Form
    {
        int count = 0;
        
        
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;

        public 스터디룸()
        {
            InitializeComponent();
            this.CenterToScreen(); //폼 가운데로 띄우기
            DB_Open();

        }

        private void DB_Open()
        {
            try
            {
                string connectionString = "User Id=moonu; Password=1111; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL = TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED) (SERVICE_NAME = xe)));";
                string commandString = "select * from r_room_res";
                DBAdapter = new OracleDataAdapter(commandString, connectionString);
                myCommandBuilder = new OracleCommandBuilder(DBAdapter);
                DS = new DataSet();
            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }

        }

        
        public Boolean study1click = false;
        public string resTime;
        public string test = "예약중";
        // 스터디룸1에 해당하는 함수
        public void select_study_room1(object sender, EventArgs e)
        {
            resTime = ((Button)sender).Text;
            
            var btn = sender as Button;
            if (btn != null)
            {
                panel1.Visible = true;
                reserveTime.Text = resTime;
                roomName.Text = study1.Text;
                btn.Enabled = false;
                btn.Text = "예약중";
                btn.BackColor = Color.Red;
               

                
                //스터디룸예약 calc = new 스터디룸예약();
                //calc.reserveTime.Text = resTime; // + (": 00 ~") + ("test") + (": 00 ");
                //calc.roomName.Text = study1.Text;

                //this.Hide(); // 창 숨기고 
                //calc.Show(); // 예약창 보여주기
            }
            room_event_func(true);

        }
        
        // 스터디룸2에 해당하는 함수
        private void select_study_room2(object sender, EventArgs e)
        {
            string resTime = ((Button)sender).Text;
            
            var btn = sender as Button;
            if (btn != null)
            {
                panel1.Visible = true;
                reserveTime.Text = resTime;
                roomName.Text = study2.Text;
                btn.Enabled = false;
                btn.Text = "예약중";
                btn.BackColor = Color.Red;

                //                스터디룸예약 calc = new 스터디룸예약();
                //                calc.reserveTime.Text = resTime; //+ (": 00 ~") + ("test") + (": 00 ");
                //                calc.roomName.Text = study2.Text;
                //                this.Hide(); // 창 숨기고 
                //                calc.Show(); // 예약창 보여주기
            }

            room_event_func(false);
        }

        private void room_event_func(Boolean boo)
        {
            study1click = boo;
            //스터디룸예약 calc = new 스터디룸예약();
            //if (study1click)
            //{
            //    calc.roomName.Text = label1.Text;
            //}
            //else
            //{
            //    calc.roomName.Text = label2.Text;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            count = count + 1;
            
            try
            {
                DS.Clear();
                DBAdapter.Fill(DS, "study");

                reserveTable = DS.Tables["study"];
                DataRow newRow = reserveTable.NewRow();


                newRow["room_res_no"] = count;
                newRow["room_no"] = 2;
                newRow["room_seat_no"] = roomName.Text;
                newRow["room_res_time"] = reserveTime.Text;


                reserveTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "study");
                DS.AcceptChanges();
                MessageBox.Show("예약이 되었습니다. \r 스터디룸 : " + roomName.Text + "\r 예약 시간 : " + reserveTime.Text);
                


            }
            catch (DataException DE)
            {
                MessageBox.Show(DE.Message);
            }
            catch (Exception DE)
            {
                MessageBox.Show(DE.Message);
            }
            panel1.Visible = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }


        //private void button1_Click(object sender, EventArgs e)
        //{
        //    스터디룸예약 calc = new 스터디룸예약();
        //    calc.reserveTime.Text = button1.Text + (": 00 ~") + button2.Text + (": 00 ");
        //    if (study1click)
        //    {
        //        calc.roomName.Text = label1.Text;
        //    }
        //    else
        //    {
        //        calc.roomName.Text = label2.Text;
        //    }
        //    this.Hide(); // 창 숨기고 
        //    calc.Show(); // 예약창 보여주기

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{

        //}
    }
}

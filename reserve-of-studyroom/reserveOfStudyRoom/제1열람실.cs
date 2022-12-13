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
    public partial class 제1열람실 : Form
    {
        DateTime dt = DateTime.Now.AddHours(2);
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;
        int count;
        public 제1열람실()
        {
            InitializeComponent();
            this.CenterToScreen(); //폼 가운데로 띄우기
            DB_Open();
        }
        private void 열람실_Load(object sender, EventArgs e)
        {
            MessageBox.Show("좌석 선택은 최대 1개 입니다.");
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

        public Boolean room1click = false;

        // 제1열람실에 해당하는 함수
        private void select_seat_room1(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;

            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightBlue;
            }

            room_event_func(seatName, true);
        }

        // 제2열람실에 해당하는 함수
        private void select_seat_room2(object sender, EventArgs e)
        {
            string seatName = ((Button)sender).Name;

            var btn = sender as Button;
            if (btn != null)
            {
                btn.BackColor = Color.LightBlue;
            }

            room_event_func(seatName, false);
        }

        // 좌석 선택시 발생하는 이벤트 관리 함수
        private void room_event_func(string seat, Boolean boo)
        {
            room1click = boo;
            showSeatNumber.Text = seat;
            reserveBtn.Enabled = true;
        }


        private void allClear_Click(object sender, EventArgs e)
        {
            A1.BackColor = SystemColors.Control;
            A2.BackColor = SystemColors.Control;
            A3.BackColor = SystemColors.Control;
            A4.BackColor = SystemColors.Control;
            A5.BackColor = SystemColors.Control;
            A6.BackColor = SystemColors.Control;
            A7.BackColor = SystemColors.Control;
            B7.BackColor = SystemColors.Control;
            B6.BackColor = SystemColors.Control;
            B5.BackColor = SystemColors.Control;
            B4.BackColor = SystemColors.Control;
            B3.BackColor = SystemColors.Control;
            B2.BackColor = SystemColors.Control;
            B1.BackColor = SystemColors.Control;
            C7.BackColor = SystemColors.Control;
            C6.BackColor = SystemColors.Control;
            C5.BackColor = SystemColors.Control;
            C4.BackColor = SystemColors.Control;
            C3.BackColor = SystemColors.Control;
            C2.BackColor = SystemColors.Control;
            C1.BackColor = SystemColors.Control;
            D7.BackColor = SystemColors.Control;
            D6.BackColor = SystemColors.Control;
            D5.BackColor = SystemColors.Control;
            D4.BackColor = SystemColors.Control;
            D3.BackColor = SystemColors.Control;
            D2.BackColor = SystemColors.Control;
            D1.BackColor = SystemColors.Control;
            reserveBtn.Enabled = false;
            showSeatNumber.Text = "";
        }
        private void button47_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            reserveTime.Text = DateTime.Now.ToString("hh:mm ~ ") + dt.ToString("hh:mm");
            userSelectSeat.Text = showSeatNumber.Text;
            if (room1click)
            {
                roomName.Text = label1.Text;
                
            }
            else
            {
                roomName.Text = label2.Text;
            }

            /*열람실예약 calc = new 열람실예약();
            calc.reserveTime.Text = DateTime.Now.ToString("hh:mm ~ ") + dt.ToString("hh:mm");
            calc.userSelectSeat.Text = showSeatNumber.Text;
            if (room1click)
            {
                calc.roomName.Text = label1.Text;
            }
            else
            {
                calc.roomName.Text = label2.Text;
            }

            calc.Show();*/

        }

        private void res_btn_Click(object sender, EventArgs e)
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
                newRow["stuName"] = nameBox.Text;
                newRow["stuID"] = IDBox.Text;
                newRow["room_seat_no"] = roomName.Text;
                newRow["room_res_time"] = reserveTime.Text;


                reserveTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "study");
                DS.AcceptChanges();
                MessageBox.Show("예약이 되었습니다. \r 열람실 : " + roomName.Text + "\r 예약 시간 : " + reserveTime.Text);
                this.Close();
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

        private void can_btn_Click(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }
    }
}

using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace reserveOfStudyRoom
{
    public partial class 제1열람실 : Form
    {
        DateTime dt = DateTime.Now.AddHours(2);
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;

        public 제1열람실()
        {
            InitializeComponent();
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
                string commandString = "select * from reserver";
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

            열람실예약 calc = new 열람실예약();
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

            calc.Show();

        }
    }
}

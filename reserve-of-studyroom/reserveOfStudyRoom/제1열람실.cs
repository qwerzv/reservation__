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

        public void room1(String text, Button btn)
        {
            room1click = true; // 열람실 예약 cs에 열람실 이름 띄어주기
            label11.Text = text; // 선택한 좌석 출력
            btn.BackColor = Color.LightBlue; // 버튼 클릭시 배경색깔 변경
            button47.Enabled = true; //버튼 클릭시 예약하기 버튼 활성화
        }

        public void room2(String text, Button btn)
        {
            label11.Text = text; // 선택한 좌석 출력
            btn.BackColor = Color.LightBlue; // 버튼 클릭시 배경색깔 변경
            button47.Enabled = true; //버튼 클릭시 예약하기 버튼 활성화
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            room1("A1\n", button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            room1("A2\n", button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            room1("A3\n", button3);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            room1("A4\n", button4);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            room1("A5\n", button5);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            room1("A6\n", button6);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            room1("A7\n", button7);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            room1("B1\n", button14);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            room1("B2\n", button13);
        }

        private void button12_Click(object sender, EventArgs e)
        { 
            room1("B3\n", button12); 
        } 

        private void button11_Click(object sender, EventArgs e)
        {
            room1("B4\n", button11);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            room1("B5\n", button10);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            room1("B6\n", button9);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            room1("B7\n", button8);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            room2("C1\n", button21);
        }

        private void button20_Click(object sender, EventArgs e)
        {
            room2("C2\n", button20);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            room2("C3\n", button19);
        }

        private void button18_Click(object sender, EventArgs e)
        {
            room2("C4\n", button18);
        }

        private void button17_Click(object sender, EventArgs e)
        {
            room2("C5\n", button17);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            room2("C6\n", button16);
        }

        private void button15_Click(object sender, EventArgs e)
        {
            room2("C7\n", button15);
        }

        private void button28_Click(object sender, EventArgs e)
        {
            room2("D1\n", button28);
        }

        private void button27_Click(object sender, EventArgs e)
        {
            room2("D2\n", button27);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            room2("D3\n", button26);
        }

        private void button25_Click(object sender, EventArgs e)
        {
            room2("D4\n", button25);
        }

        private void button24_Click(object sender, EventArgs e)
        {
            room2("D5\n", button24);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            room2("D6\n", button23);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            room2("D7\n", button22);
        }

        private void button48_Click(object sender, EventArgs e)
        {
            button1.BackColor = SystemColors.Control;
            button2.BackColor = SystemColors.Control;
            button3.BackColor = SystemColors.Control;
            button4.BackColor = SystemColors.Control;
            button5.BackColor = SystemColors.Control;
            button6.BackColor = SystemColors.Control;
            button7.BackColor = SystemColors.Control;
            button8.BackColor = SystemColors.Control;
            button9.BackColor = SystemColors.Control;
            button10.BackColor = SystemColors.Control;
            button11.BackColor = SystemColors.Control;
            button12.BackColor = SystemColors.Control;
            button13.BackColor = SystemColors.Control;
            button14.BackColor = SystemColors.Control;
            button15.BackColor = SystemColors.Control;
            button16.BackColor = SystemColors.Control;
            button17.BackColor = SystemColors.Control;
            button18.BackColor = SystemColors.Control;
            button19.BackColor = SystemColors.Control;
            button20.BackColor = SystemColors.Control;
            button21.BackColor = SystemColors.Control;
            button22.BackColor = SystemColors.Control;
            button23.BackColor = SystemColors.Control;
            button24.BackColor = SystemColors.Control;
            button25.BackColor = SystemColors.Control;
            button26.BackColor = SystemColors.Control;
            button27.BackColor = SystemColors.Control;
            button28.BackColor = SystemColors.Control;
            button47.Enabled = false;
            label11.Text = "";
        }
        private void button47_Click(object sender, EventArgs e)
        {

            열람실예약 calc = new 열람실예약();
            calc.label13.Text = DateTime.Now.ToString("hh:mm ~ ") + dt.ToString("hh:mm");
            calc.label6.Text = label11.Text;
            if (room1click)
            {
                calc.label1.Text = label1.Text;
            }
            else
            {
                calc.label1.Text = label2.Text;
            }

            calc.Show();

        }

        private void 제1열람실ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void 제2열람실ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            제2열람실 calc2 = new 제2열람실();
            calc2.Show();
        }
    }
}

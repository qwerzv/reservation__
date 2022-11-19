using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reserveOfStudyRoom
{
    public partial class 제1열람실 : Form
    {
        DateTime dt = DateTime.Now.AddHours(2);

        public 제1열람실()
        {
            InitializeComponent();
        }

        private void 열람실_Load(object sender, EventArgs e)
        {
            MessageBox.Show("좌석 선택은 최대 1개 입니다.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String SQL = "SELECT * FROM ";

            label11.Text = "A1\n";
            button1.BackColor = Color.LightBlue;
            button47.Enabled = true; //버튼 활성화
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label11.Text = "A2\n";
            button2.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label11.Text = "A3\n";
            button3.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label11.Text = "A4\n";
            button4.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label11.Text = "A5\n";
            button5.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label11.Text = "A6\n";
            button6.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label11.Text = "A7\n";
            button7.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            label11.Text = "B1\n";
            button14.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            label11.Text = "B2\n";
            button13.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            label11.Text = "B3\n";
            button12.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            label11.Text = "B4\n";
            button11.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label11.Text = "B5\n";
            button10.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label11.Text = "B6\n";
            button9.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label11.Text = "B7\n";
            button8.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label11.Text = "C1\n";
            button21.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label11.Text = "C2\n";
            button20.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label11.Text = "C3\n";
            button19.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label11.Text = "C4\n";
            button18.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            label11.Text = "C5\n";
            button17.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            label11.Text = "C6\n";
            button16.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            label11.Text = "C7\n";
            button15.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label11.Text = "D1\n";
            button28.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label11.Text = "D2\n";
            button27.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label11.Text = "D3\n";
            button26.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button25_Click(object sender, EventArgs e)
        {
            label11.Text = "D4\n";
            button25.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button24_Click(object sender, EventArgs e)
        {
            label11.Text = "D5\n";
            button24.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button23_Click(object sender, EventArgs e)
        {
            label11.Text = "D6\n";
            button23.BackColor = Color.LightBlue;
            button47.Enabled = true;
        }

        private void button22_Click(object sender, EventArgs e)
        {
            label11.Text = "D7\n";
            button22.BackColor = Color.LightBlue;
            button47.Enabled = true;
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

            label11.Text = "";
        }
        private void button47_Click(object sender, EventArgs e)
        {

            열람실예약 calc = new 열람실예약();
            calc.label13.Text = DateTime.Now.ToString("hh:mm ~ ") + dt.ToString("hh:mm");
            calc.label6.Text = label11.Text;

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

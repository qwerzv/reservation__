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
    public partial class 스터디룸 : Form
    {
        public 스터디룸()
        {
            InitializeComponent();
            this.CenterToScreen(); //폼 가운데로 띄우기
        }
        public Boolean study1click = false;

        // 스터디룸1에 해당하는 함수
        public void select_study_room1(object sender, EventArgs e)
        {
            string resTime = ((Button)sender).Text;

            var btn = sender as Button;
            if (btn != null)
            {

                스터디룸예약 calc = new 스터디룸예약();
                calc.reserveTime.Text = resTime; // + (": 00 ~") + ("test") + (": 00 ");
                calc.roomName.Text = study1.Text;

                this.Hide(); // 창 숨기고 
                calc.Show(); // 예약창 보여주기
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

                스터디룸예약 calc = new 스터디룸예약();
                calc.reserveTime.Text = resTime; //+ (": 00 ~") + ("test") + (": 00 ");
                calc.roomName.Text = study2.Text;
                this.Hide(); // 창 숨기고 
                calc.Show(); // 예약창 보여주기
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

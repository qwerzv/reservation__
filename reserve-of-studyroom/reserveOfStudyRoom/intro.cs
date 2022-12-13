using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using Oracle.DataAccess.Client;

namespace reserveOfStudyRoom
{
    public partial class intro : Form
    {
        private int SelectedRowIndex;
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;

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


        public intro()
        {
            InitializeComponent();
            //DB_Open();

            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("font/NanumSquareNeo-bRg.ttf");
            Font font = new Font(privateFont.Families[0], 24f);
            Font font2 = new Font(privateFont.Families[0], 18f);
            studentCertification.Font = readingRoom.Font = studyRoom.Font = font;
            label1.Font = font2;
        }

        public void fontBorderSetting (ButtonBase btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
        }

        private void intro_Load(object sender, EventArgs e)
        {
            studentCertification.Left = (this.ClientSize.Width - studentCertification.Width) / 2;
            studentCertification.Top = (this.ClientSize.Height - studentCertification.Height) / 2;

            label1.Left = (this.ClientSize.Width - label1.Width) / 2;
            label1.Top = (this.ClientSize.Height - label1.Height) / 2;

            fontBorderSetting(studentCertification);
            fontBorderSetting(readingRoom);
            fontBorderSetting(studyRoom);
        }

        private void studentCertification_Click(object sender, EventArgs e)
        {
            insert form2 = new insert();
            form2.ShowDialog();

            panel1.Visible = true;
        }

        private void readingRoom_Click(object sender, EventArgs e)
        {
            제1열람실 calc = new 제1열람실();
            calc.Show();
        }

        private void studyRoom_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

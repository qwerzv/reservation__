using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace reserveOfStudyRoom
{
    public partial class insert : Form
    {
        private int SelectedRowIndex;
        OracleDataAdapter DBAdapter;
        DataSet DS;
        OracleCommandBuilder myCommandBuilder;
        DataTable reserveTable;

        private void ClearTextBoxes()
        {
            id.Clear();
            name.Clear();
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

        public insert()
        {
            InitializeComponent();
            DB_Open();

            PrivateFontCollection privateFont = new PrivateFontCollection();
            privateFont.AddFontFile("font/NanumSquareNeo-bRg.ttf");
            Font font = new Font(privateFont.Families[0], 24f);
            label1.Font = label2.Font = font;
        }

        private void AppendBtn_Click(object sender, EventArgs e)
        {
            try
            {
                MessageBox.Show("텍스트 상자에 모든 데이터 입력하셨으면 추가합니다!");
                DS.Clear();
                DBAdapter.Fill(DS, "reserve");

                reserveTable = DS.Tables["reserve"];
                DataRow newRow = reserveTable.NewRow();

                newRow["id"] = Convert.ToInt32(id.Text);
                newRow["name"] = name.Text;

                reserveTable.Rows.Add(newRow);

                DBAdapter.Update(DS, "reserve");
                DS.AcceptChanges();
                ClearTextBoxes();
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

        private void close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using System.Data;

namespace reserveOfStudyRoom
{
    class DBClass
    {
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
               // MessageBox.Show(DE.Message);
            }

        }

    }
}

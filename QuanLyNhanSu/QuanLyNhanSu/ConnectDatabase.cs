using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;


namespace QuanLyNhanSu
{
    class ConnectDatabase
    {
        string strConnect = "Data Source=DESKTOP-4H2CDN2;Initial Catalog=TTN_QLNHANSU_01;Integrated Security=True";
        SqlConnection sqlConnection;
        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        SqlDataReader sqlDataReader;
        DataSet dataSet = new DataSet();

        void KetNoi()
        {
            sqlConnection = new SqlConnection(strConnect);
            sqlConnection.Open();
        }

        void NgatKetNoi()
        {
            sqlConnection.Close();
        }

        public void ThucThiKetNoi(string strsql)
        {
            KetNoi();
            sqlCommand = new SqlCommand(strsql, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            NgatKetNoi();
        }
        public void loadDataGridView(DataGridView dg, string strselect)
        {
            dataSet.Clear();
            sqlDataAdapter = new SqlDataAdapter(strselect, strConnect);
            sqlDataAdapter.Fill(dataSet, "query");
            dg.DataSource = dataSet.Tables[0];
        }

        
    }
}

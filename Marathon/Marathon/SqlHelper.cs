using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Marathon
{
    class SqlHelper
    {
        private string conString = ConfigurationManager.ConnectionStrings["marathon"].ConnectionString;
        private SqlConnection conn;
        private SqlCommand comm;
        private SqlDataReader sdr;
        private DataSet ds;
        private void OpenConnection()
        {
            if (conn == null)
            {
                conn = new SqlConnection(conString);
            }
            else if (conn.State == ConnectionState.Open)
            {
                return;
            }
            this.conn.Open();
        }
        private void CloseConnection() {
            conn.Dispose();
            conn.Close();
            conn = null;
        }
        public bool IsExist(string sqlString, SqlParameter[] values)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            foreach (SqlParameter item in values)
            {
                comm.Parameters.Add(item);
            }
            sdr = comm.ExecuteReader();
            try
            {
                if (sdr.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally 
            {
                CloseConnection();
            }
        }
        public SqlDataReader GetDataReader(string sqlString, SqlParameter[] values)
        {
            try
            {
                OpenConnection();
                comm = new SqlCommand(sqlString, conn);
                foreach (SqlParameter item in values)
                {
                    comm.Parameters.Add(item);
                }
                SqlDataReader sdr = comm.ExecuteReader();
                return sdr;
            }
            catch (Exception)
            {

                throw;
            }

        }
        public DataSet GetDataSet(string sqlString)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            ds = new DataSet();
            var sda = new SqlDataAdapter(comm);
            sda.Fill(ds);
            CloseConnection();
            return ds;
        }
        public int UpdateDataRows(string sqlString, SqlParameter[] values)
        {
            OpenConnection();
            comm = new SqlCommand(sqlString, conn);
            foreach (SqlParameter item in values)
            {
                comm.Parameters.Add(item);
            }
            int i = comm.ExecuteNonQuery();
            CloseConnection();
            return i;
        }
    }
}

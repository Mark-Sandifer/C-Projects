using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;

namespace ATM
{
    public class ConnectorClass
    {
        private SqlConnection SqlConnect;

        public bool Connect(string Address, string DBName)
        {
            try
            {
                SqlConnect = new SqlConnection($"Data Source={Address};Initial Catalog={DBName};trusted_connection=true");
                SqlConnect.Open();
            }
            catch (Exception)
            {
                return false;
            }
            return true;
        }
        public void Create(string Table, string Column, string Val)
        {
            SqlCommand command = new SqlCommand($"insert into {Table} {Column} values {Val}", SqlConnect);
            Console.WriteLine(command.ToString());
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = command;
            adapter.InsertCommand.ExecuteNonQuery();
            command.Dispose();
        }
        public List<object[]> Read(string Table, string Fields = "*")
        {
            SqlCommand command = new SqlCommand($"select {Fields} from {Table}", SqlConnect);
            SqlDataReader reader = command.ExecuteReader();
            List<object[]> list = new List<object[]>();
            while (reader.Read())
            {
                object[] data = new object[reader.FieldCount];
                reader.GetValues(data);
                list.Add(data);
            }
            reader.Close();
            command.Dispose();
            return list;
        }
        public void Update(string Table, string Column, string Val, string TColumn, string TVal)
        {
            SqlCommand command = new SqlCommand($"update {Table} set {Column} = {Val} where {TColumn} = {TVal}", SqlConnect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = command;
            adapter.UpdateCommand.ExecuteNonQuery();
            command.Dispose();
        }
        public void Delete(string Table, string TColumn, string TVal)
        {
            SqlCommand command = new SqlCommand($"delete from {Table} where {TColumn} = {TVal}", SqlConnect);
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.DeleteCommand = command;
            adapter.DeleteCommand.ExecuteNonQuery();
            command.Dispose();
        }
        public void Cleanup()
        {
            SqlConnect.Close();
        }
    }
}
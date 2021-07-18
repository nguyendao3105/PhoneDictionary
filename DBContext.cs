using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPhoneDic
{
    public class DBContext //singleton
    {
        static DBContext instance;

        private string connectionString;
        private SqlConnection cnn;

        public static DBContext Instance()
        {
            if (instance == null)
            {
                instance = new DBContext();
            }
            return instance;
        }
        protected DBContext()
        {
            connectionString = @"Data Source=(localdb)\ProjectsV13;Initial Catalog=testdb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        }
        public int InsertCustomer(Customer newCustomer)
        {
            string sql = "insert into Customer ([Name], [Address],[Email],[PhoneNumber]) values(@name,@address,@email,@phone)";
            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {

                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = newCustomer.Name;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = newCustomer.Address;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = newCustomer.Email;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = newCustomer.PhoneNumber;
                    cnn.Open();
                    int rowsAdded = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return rowsAdded;
                }
            }
        }

        public int ResetDB()
        {
            string sql = "delete  from [dbo].Customer";
            using (cnn = new SqlConnection(connectionString))
            {

                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    int rowsDeleted = cmd.ExecuteNonQuery();
                }

            }
            return -1;
        }

        public Dictionary<int, Customer> LoadAllCustomer()
        {
            Dictionary<int, Customer> result = new Dictionary<int, Customer>();
            string sql = "select [Id],[Name],[Address],[Email],[PhoneNumber]  from [dbo].Customer order by [Name]";
            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var name = reader["Name"].ToString();
                                var address = reader["Address"].ToString();
                                var email = reader["Email"].ToString();
                                var phone = reader["PhoneNumber"].ToString();
                                var id = reader.GetInt32(0);
                                result.Add(id, new Customer(name, address, email, phone));
                            }
                        }
                    }
                }
            }
            return result;
        }

        public DataSet GetDataSet_AllCustomerRows()
        {
            cnn = new SqlConnection(connectionString);
            string select = "SELECT * from [dbo].[Customer]";

            cnn.Open();
            SqlDataAdapter da = new SqlDataAdapter(select, cnn);

            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            cnn.Close();
            return ds;
        }

        public void DeleteCustomer(string id)
        {
            string sql = "delete  from [dbo].Customer where Id = @id";
            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    cnn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<String> GetAllCustomerNames()
        {
            List<string> result = new List<string>();
            string sql = "select [Name]  from [dbo].Customer order by [Name]";
            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var name = reader["Name"].ToString();
                                result.Add(name);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public List<String> GetAllCustomerPhone()
        {
            List<string> result = new List<string>();
            string sql = "select [PhoneNumber]  from [dbo].Customer order by [PhoneNumber]";
            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.HasRows)
                        {
                            while (reader.Read())
                            {
                                var phone = reader["PhoneNumber"].ToString();
                                result.Add(phone);
                            }
                        }
                    }
                }
            }
            return result;
        }
        public DataSet SearchCustomerName(string name)
        {
            cnn = new SqlConnection(connectionString);
            string select = "SELECT * FROM Customer WHERE Name LIKE '%" + name + "%'";

            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(select, cnn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            cnn.Close();
            return ds;
        }
        public DataSet SearchCustomerPhone(string phone)
        {
            cnn = new SqlConnection(connectionString);
            string select = "SELECT * FROM Customer WHERE PhoneNumber LIKE '%" + phone + "%'";

            cnn.Open();

            SqlDataAdapter da = new SqlDataAdapter(select, cnn);
            DataSet ds = new DataSet();

            da.Fill(ds, "Customer");
            cnn.Close();
            return ds;
        }

        public int UpdateCustomer(string id, string name, string email, string phone, string address)
        {
            string sql = "UPDATE Customer SET Name = @name, Address = @address, Email = @email, PhoneNumber = @phone WHERE Id = @id";

            using (cnn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(sql, cnn))
                {
                    cnn.Open();
                    cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                    cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
                    cmd.Parameters.Add("@email", SqlDbType.NVarChar).Value = email;
                    cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = address;
                    cmd.Parameters.Add("@phone", SqlDbType.NVarChar).Value = phone;
                    var nrow = cmd.ExecuteNonQuery();
                    cnn.Close();
                    return nrow;
                }
            }
        }
    }
}

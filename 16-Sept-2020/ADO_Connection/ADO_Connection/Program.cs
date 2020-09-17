using System;
using System.Data.SqlClient; //.. Includes DataProvider classes Connection, Command, DataAdapter, DataReader, SQLException


namespace ADO_Connection
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().CreateTable();

            Console.ReadKey();
        }
        public void CreateTable()
        {
            SqlConnection con = null;
            try
            {
                // Creating Connection  

                //....data source = server_name, database= Database_name, integrate security = If using MSSql server, no need to mention username and password
                con = new SqlConnection("data source=.; database= Student; integrated security=true");

                // writing sql query  and passing Connection object

                SqlCommand cm = new SqlCommand("create table student(id int not null,\n" +
                    "name varchar(100), \n" +
                    "email_id varchar(90),\n" +
                    "join_date Date)",con);

                // Opening Connection  
                con.Open();
                // Executing the SQL query  

                int rows_affected = cm.ExecuteNonQuery();
                Console.WriteLine("Rows affected: "+rows_affected);
                // Displaying a message  
                Console.WriteLine("Table created Successfully");
            }
            
            catch (Exception e)
            {
                Console.WriteLine("OOPs, something went wrong." +e.Message);
            }
            // Closing the connection  
            finally
            {
                con.Close();
            }
        }
    }
}
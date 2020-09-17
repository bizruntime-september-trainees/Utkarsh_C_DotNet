using System;  
using System.Data.SqlClient;  


namespace ADO_Retrieve

    {
        class Program
        {
            static void Main(string[] args)
            {
                new Program().CreateTable();
            }
            public void CreateTable()
            {
                SqlConnection con = null;
                try
                {
                    // Creating Connection  
                    con = new SqlConnection("data source=.; database= Student; integrated security=true");
                    // writing sql query  
                    SqlCommand cm = new SqlCommand("Select * from student", con);
                    // Opening Connection  
                    con.Open();

                    // Executing the SQL query  (Sending the command text to the Connection and builts SqlDataReader object

                    SqlDataReader sdr = cm.ExecuteReader();
                    // Iterating Data  
                    while (sdr.Read())
                    {
                    //.......DataReader_object[column_name]

                        Console.WriteLine(sdr["id"] + " " + sdr["name"] + " " + sdr["email_id"] +" "+sdr["join_date"]); // Displaying Record  
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("OOPs, something went wrong.\n" + e);
                }
                // Closing the connection  
                finally
                {
                    con.Close();
                }
            }
        }
    }

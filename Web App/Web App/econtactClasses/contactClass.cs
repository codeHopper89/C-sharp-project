using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;


namespace Web_App.econtactClasses
{
    internal class contactClass
    {
        //Getter Setter properties
        //Acts as data carrier in our application
        public int ContactID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string ContactNo { get; set; }
        public string Address { get; set; }
        public string Gender { get; set; }

        // static method to create database connection string
        static string myconnstrng = ConfigurationManager.ConnectionStrings["connstring"].ConnectionString;

        //Creating a method
        //Selecting data from database

        //DataTable is a temporary table to store the list of data from the database

        public DataTable Select()
        {
            //Step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);
            DataTable dt = new DataTable();
            try
            {
                //Step 2: Writing SQL Query
                string sql = "SELECT * FROM tbl_contact";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating SQL Data Adapter using cmd
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //Display error message if there is any exception
                 MessageBox.Show(ex.Message);   
            }
            finally
            {
                conn.Close();
            }
            return dt;
        }


        //Inserting data into database
        public bool Insert(contactClass c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2: Writing SQL Query to insert data
                string sql = "INSERT INTO tbl_contact(FirstName,LastName,ContactNo,Address,Gender) VALUES(@FirstName,@LastName,@ContactNo,@Address,@Gender)";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add data
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);

                //Opening connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the value of rows will be greater than zero else it will be less than zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                //Display error message if there is any exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing the connection
                conn.Close();
            }
            return isSuccess;


        }

        //Method to update data in database from our application
        public bool Update(contactClass c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2: Writing SQL Query to update data
                string sql = "UPDATE tbl_contact SET FirstName=@FirstName,LastName=@LastName,ContactNo=@ContactNo,Address=@Address,Gender=@Gender WHERE ContactID=@ContactID";

                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);

                //Creating parameters to add value
                cmd.Parameters.AddWithValue("@FirstName", c.FirstName);
                cmd.Parameters.AddWithValue("@LastName", c.LastName);
                cmd.Parameters.AddWithValue("@ContactNo", c.ContactNo);
                cmd.Parameters.AddWithValue("@Address", c.Address);
                cmd.Parameters.AddWithValue("@Gender", c.Gender);
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);

                //Opening connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();

                //If the query runs successfully then the value of rows will be greater than zero else it will be less than zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }

            }
            catch (Exception ex)
            {
                //Display error message if there is any exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing the connection
                conn.Close();
            }
            return isSuccess;

        }

        //Method to delete data from database in our application
        public bool Delete(contactClass c)
        {
            //Creating a default return type and setting its value to false
            bool isSuccess = false;

            //Step 1: Database connection
            SqlConnection conn = new SqlConnection(myconnstrng);

            try
            {
                //Step 2: Writing SQL Query to delete data
                string sql = "DELETE FROM tbl_contact WHERE ContactID=@ContactID";
                //Creating cmd using sql and conn
                SqlCommand cmd = new SqlCommand(sql, conn);
                //Creating parameters to add value
                cmd.Parameters.AddWithValue("@ContactID", c.ContactID);
                //Opening connection
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                //If the query runs successfully then the value of rows will be greater than zero else it will be less than zero
                if (rows > 0)
                {
                    isSuccess = true;
                }
                else
                {
                    isSuccess = false;
                }
            }
            catch (Exception ex)
            {
                //Display error message if there is any exception
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //Closing the connection
                conn.Close();
            }
            return isSuccess;
        }
    }

}


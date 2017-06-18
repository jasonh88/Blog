using Blog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Blog.Services
{
    public class ProgressService
    {   //Get all Progress
        public List<Progress> GetProgress()
        {
            //Instantiate a new list of Progress with a constructor
            List<Progress> progressList = new List<Progress>();
            //Make a new connection string referencing the credentials to the database
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Progress_SelectAll", sqlConn))
                {
                    //Open the connection and read the data from SQL
                    sqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Progress p = new Progress();
                        p.Id = reader.GetInt32(0);
                        p.Pushups = reader.GetInt32(1);
                        p.Situps = reader.GetInt32(2);
                        p.Steps = reader.GetInt32(3);
                        p.Pullups = reader.GetInt32(4);
                        p.Bench = reader.GetInt32(5);
                        p.Squat = reader.GetInt32(6);
                        p.Notes = reader.GetString(7);
                        p.DateAdded = reader.GetDateTime(8);
                        p.DateModified = reader.GetDateTime(9);

                        progressList.Add(p);
                        //Add the data to the new list that was previously instantiated.
                    }
                }
            }
            return progressList;
        }

        //Insert Progress
        public int CreateProgress(Progress model)
        {
            int returnValue = 0;
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Progress_Insert", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    //Refactor later..
                    if (model.Pushups == null)
                    {
                        cmd.Parameters.AddWithValue("@Pushups", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Pushups", model.Pushups);
                    }

                    if (model.Situps == null)
                    {
                        cmd.Parameters.AddWithValue("@Situps", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Situps", model.Situps);
                    }
                    if (model.Steps == null)
                    {
                        cmd.Parameters.AddWithValue("@Steps", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Steps", model.Steps);
                    }
                    if (model.Pullups == null)
                    {
                        cmd.Parameters.AddWithValue("@Pullups", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Pullups", model.Pullups);
                    }
                    if (model.Bench == null)
                    {
                        cmd.Parameters.AddWithValue("@Bench", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Bench", model.Bench);
                    }
                    if (model.Squat == null)
                    {
                        cmd.Parameters.AddWithValue("@Squat", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Squat", model.Squat);
                    }
                    if (model.Notes == null)
                    {
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Notes", model.Notes);
                    }

                    SqlParameter parm = new SqlParameter();
                    parm.ParameterName = "@Id";
                    parm.SqlDbType = System.Data.SqlDbType.Int;
                    parm.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(parm);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();

                    returnValue = (int)cmd.Parameters["@id"].Value;
                }
            }
            return returnValue;
        }

        //Delete Progress
        public void DeleteProgress(int Id)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Progress_Delete", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;

                    cmd.Parameters.AddWithValue("@Id", Id);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        //Update Progress
        public void UpdateProgress(int id, Progress model)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Progress_Update", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    
                    //Refactor later..
                    if (model.Pushups == null)
                    {
                        cmd.Parameters.AddWithValue("@Pushups", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Pushups", model.Pushups);
                    }

                    if (model.Situps == null)
                    {
                        cmd.Parameters.AddWithValue("@Situps", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Situps", model.Situps);
                    }
                    if (model.Steps == null)
                    {
                        cmd.Parameters.AddWithValue("@Steps", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Steps", model.Steps);
                    }
                    if (model.Pullups == null)
                    {
                        cmd.Parameters.AddWithValue("@Pullups", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Pullups", model.Pullups);
                    }
                    if (model.Bench == null)
                    {
                        cmd.Parameters.AddWithValue("@Bench", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Bench", model.Bench);
                    }
                    if (model.Squat == null)
                    {
                        cmd.Parameters.AddWithValue("@Squat", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Squat", model.Squat);
                    }
                    if (model.Notes == null)
                    {
                        cmd.Parameters.AddWithValue("@Notes", DBNull.Value);
                    }
                    else
                    {
                        cmd.Parameters.AddWithValue("@Notes", model.Notes);
                    }

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }


}
using Blog.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace Blog.Services
{
    public class BlogsService
    {
        //Get all blogs
        public List<Blogs> GetBlogs()
        {
            List<Blogs> blogList = new List<Blogs>();

            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Blogs_SelectAll", sqlConn))
                {
                    sqlConn.Open();
                    SqlDataReader reader = cmd.ExecuteReader(System.Data.CommandBehavior.CloseConnection);
                    while (reader.Read())
                    {
                        Blogs b = new Blogs();
                        b.Id = reader.GetInt32(0);
                        b.Title = reader.GetString(1);
                        b.Content = reader.GetString(2);
                        b.Image = reader.GetString(3);

                        blogList.Add(b);
                    }
                }
            }
            return blogList;
        }




        //Insert blogs
        public int CreateBlog(Blogs model)
        {
            int retVal = 0;
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Blogs_Insert", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Title", model.Title);
                    cmd.Parameters.AddWithValue("@Content", model.Content);
                    cmd.Parameters.AddWithValue("@Image", model.Image);

                    SqlParameter parm = new SqlParameter();
                    parm.ParameterName = "@Id";
                    parm.SqlDbType = System.Data.SqlDbType.Int;
                    parm.Direction = System.Data.ParameterDirection.Output;
                    cmd.Parameters.Add(parm);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();

                    retVal = (int)cmd.Parameters["@id"].Value;
                }
            }
            return retVal;
        }

        //Delete Blogs
        public void DeleteBlog(int Id)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Blogs_Delete", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", Id);

                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }

        }

        //Update Blogs
        public void UpdateBlog(int id, Blogs model)
        {
            string connString = System.Configuration.ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            using (SqlConnection sqlConn = new SqlConnection(connString))
            {
                using (SqlCommand cmd = new SqlCommand("dbo.Blogs_Update", sqlConn))
                {
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Id", id);
                    cmd.Parameters.AddWithValue("@Title", model.Title);
                    cmd.Parameters.AddWithValue("@Content", model.Content);
                    cmd.Parameters.AddWithValue("@Image", model.Image);


                    sqlConn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }





    }
}
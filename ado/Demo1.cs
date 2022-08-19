using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adv.ado
{
    class Demo1
    {
        static void Main(string[] args)
        {
            string cstr = "server=DESKTOP-PKH1ED2\\SQLEXPRESS02;Database=hr;Integrated Security=True";
             SqlConnection con= null;
            try
            {
                con = new SqlConnection(cstr);
                con.Open();
                SqlCommand sqlCommand = new SqlCommand("select first_name,salary from employees", con);
                SqlDataReader dr = sqlCommand.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine("name=" + dr["first_name"] + "salary=" + dr[1]);
                }



            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            finally
            {
                if (con != null)
                    con.Close();

            }
        }
    }
    class Demo2
    {
        public static void Main(string[] args)
        {
            string cstr = "server=DESKTOP-PKH1ED2\\SQLEXPRESS02;Database=hr;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new(cstr);
                con.Open();
                SqlCommand sqlcommand = new("insert into employees(1,'piyu','xyz','piyu@gmail.com',467373,12-4-2019,121,1)",con);


            }
            catch
            {

            }


        }
    }


   
}

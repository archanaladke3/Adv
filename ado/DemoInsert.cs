using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adv.ado
{
    static class Dbconnect
    {
        public static SqlConnection getConnection()
        {

            string str = "server=DESKTOP-PKH1ED2\\SQLEXPRESS02;Database=studentPortal;Integrated Security=True";
            SqlConnection con = null;
            try
            {
                con = new SqlConnection(str);
                con.Open();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return con;
        }
    }
    class DemoInsert
    {
        public static void Main(string[] args)
        {
            SqlConnection con = Dbconnect.getConnection();
            Console.WriteLine("enter id,name percentage");
            int rollno = int.Parse(Console.ReadLine());
            string name = Console.ReadLine();
            SqlCommand cmd = new SqlCommand("insert into student values(@id,@name)",con);
            cmd.Parameters.AddWithValue("@id", rollno);
            cmd.Parameters.AddWithValue("@name", name);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("record inserted");
         
        }
        
        
    }
    class Demodelete
    {
        public static void Main(string[] args)
        {

        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Adv.ado
{
    static class Dbconnect1
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
            catch (Exception e)
            {
                Console.WriteLine(e.Message);

            }
            return con;
        }
    }
    class DemoDelete
    {
        public static void Main(string[] args)

        {
            Console.WriteLine("enter roll no");
            int no = Convert.ToInt32(Console.ReadLine());

            SqlConnection con = Dbconnect.getConnection();
         
            SqlCommand cmd = new SqlCommand("delete from student where rollno=125", con);
           
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("record deleted");

        }

    }
    class DemoUpdted
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("enter roll no");
            int id = Convert.ToInt32(Console.ReadLine());
            SqlConnection con = Dbconnect.getConnection();

            SqlCommand cmd = new SqlCommand("update student set name='priyanka where rollno=@id", con);

            int i = cmd.ExecuteNonQuery();
            if (i > 0)
                Console.WriteLine("Record updated");

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Adv.ado
{
    class DisconnectedDemo
    {
        public static void Main(string[] args)
        {
            SqlConnection con = null;
            con = Dbconnect.getConnection();
            SqlDataAdapter sda = new SqlDataAdapter("select * from student", con);
            DataSet ds = new DataSet();
            sda.Fill(ds, "student");
            foreach (DataRow dr in ds.Tables["student"].Rows)
            {
                Console.WriteLine(dr[0] + "  " + dr[1] );
            }
        }
    }
}

using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Common;

namespace ADO.net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            string connect = @"Server =.\SQLExpress;AttachDbFilename=C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\demo_web.mdf;Database=demo_web;
            Trusted_Connection=Yes";
            string command = "SELECT * from product";
            SqlConnection conn = new SqlConnection(connect);
            //SqlCommand sqlcommand;
            //conn.Open();
            //sqlcommand = new SqlCommand(command, conn);
            //SqlDataReader datareader = sqlcommand.ExecuteReader();
            //while (datareader.Read())
            //{
            //    txt1.Text=datareader.GetString(1);
            //}
            //conn.Close();
            SqlDataAdapter sa = new SqlDataAdapter(command, conn);
            DataSet da = new DataSet();
            sa.Fill(da, "product");
            dg.DataSource = da.Tables["product"];
            DataTable tbl = da.Tables["product"];
            //var m = tbl.AsEnumerable().Select(n => new{ id=n.Field<string>(0)});
            //{
            //    id = n.Field<string>("id"),
            //    name = n.Field<string>("name"),
            //    description = n.Field<string>("description"),
            //    price = n.Field<float>("price"),
            //    img = n.Field<string>("img")

            //});


            //txt1.Text = m.First();


            //product[] abc = new product[] { new product("abc", "cc", "b", 2, "qwe"), new product("a", "cc", "b", 3, "qwe"), new product("b", "cc", "b", 4, "qwe")};
            //IEnumerable<demo> query = abc.Where(n => n.price >= 2).Select(n => new demo {i=n.id,n=n.name }).OrderByDescending(n=>n.n).Take(2);
            //foreach(var u in query)
            //{
            //    txt1.Text = u.i.ToString();
            //    txt2.Text = u.n.ToString();
            //}
            IEnumerable<demo> query = tbl.AsEnumerable().Select(n => new demo {i=n.Field<string>("id"),n=n.Field<string>("name") }).Take(1);
            foreach (IEnumerable<demo> u in query)
            {
                txt1.Text = u.i;
                txt2.Text = u.n;
            }

        }



    }
}

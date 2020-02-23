using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace WebApplication6
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;Connect Timeout=30");
        protected void Page_Load(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
            con.Open();
            DisplayData();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Table1 values('" + nome.Text + "','" + sobrenome.Text + "','" + Convert.ToDecimal(nota1.Text) + "','" + Convert.ToDecimal(nota2.Text) + "','" + Convert.ToDecimal(nota3.Text) +"','" + ((Convert.ToDecimal(nota1.Text) + Convert.ToDecimal(nota2.Text) + Convert.ToDecimal(nota3.Text))/3) + "')";
            cmd.ExecuteNonQuery();

            nome.Text = "";
            sobrenome.Text = "";
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            DisplayData();
        }

        public void DisplayData()
        {

            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText ="select * from Table1";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from Table1 where nome='"+ nome.Text +"'";
            cmd.ExecuteNonQuery();

            nome.Text = "";
            DisplayData();
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "update Table1 set nome='"+nome.Text+"',sobrenome='"+sobrenome.Text+"',nota1='"+nota1.Text+"',nota2='"+nota2.Text+"',nota3='"+ nota3.Text+"',media='"+ ((Convert.ToDecimal(nota1.Text) + Convert.ToDecimal(nota2.Text) + Convert.ToDecimal(nota3.Text)) / 3)+"' where id=" + Convert.ToInt32(editId.Text) + "";
            cmd.ExecuteNonQuery();

            nome.Text = "";
            sobrenome.Text = "";
            nota1.Text = "";
            nota2.Text = "";
            nota3.Text = "";
            DisplayData();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from Table1 where media > 6";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            GridView1.DataSource = dt;
            GridView1.DataBind();
        }
    }
}
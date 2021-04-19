using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Model;
using Dal;

namespace ProjTransporteUrbano
{
    public partial class frmCadastroLogradouro : System.Web.UI.Page
    {
        public string strConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            strConn = ("Data Source=BR-PF1CDNKU\\SQLEXPRESS;Initial Catalog=DB_P2;Integrated Security=true");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            #region ExecutaComando
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = conn;
            //        cmd.CommandType = CommandType.Text;
            //        cmd.CommandText = @"INSERT INTO Logradouro(NomeLogradouro, id_Cidade) VALUES ( @NomeLogradouro, @id_Cidade )";

            //        try
            //        {
            //            cmd.Parameters.AddWithValue("@NomeLogradouro", txtNomeLogradouro.Text.ToString());
            //            cmd.Parameters.AddWithValue("@id_Cidade", txtid_Cidade.Text.ToString());

            //        }
            //        catch (SqlException ex)
            //        {
            //            Response.Write("<script>alert('Os dados não foram cadastrados verifique o erro:'" + ex.Message.ToString() + ");</script>");
            //        }
            //        try
            //        {
            //            conn.Open();
            //            cmd.ExecuteNonQuery();
            //            Response.Write("<script>alert('Os dados foram cadastrados com sucesso');</script>");
            //        }
            //        catch (SqlException ex)
            //        {
            //            Response.Write("<script>alert('Os dados não foram cadastrados verifique o erro'" + ex.Message.ToString() + ");</script>");
            //            return;
            //        }

            //    }
            //}
            #endregion
            Logradouro logradouro = GetData();

            var db = new LogradouroCadastroDB();
            if (db.Insert(logradouro))
            {
                Response.Write("<script language='javascript'>alert('Os dados foram cadastrados com sucesso!');</script>");
                LoadGrid();
            }
            else
                Response.Write("<script language='javascript'>alert('Erro!\n\n Os dados não foram cadastrados verifique se os campos estão corretos.');</script>");
        }
        public Logradouro GetData()
        {
            return new Logradouro()
            {
                NomeLogradouro = txtNomeLogradouro.Text.ToString(),
                id_Cidade = int.Parse(txtid_Cidade.Text.ToString())
            };

        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dgvLogradouro.DataSource = new EmpresaCadastroDB().GetAll();
            dgvLogradouro.DataBind();
        }
    }
}
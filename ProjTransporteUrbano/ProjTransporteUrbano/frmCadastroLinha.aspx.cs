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
    public partial class frmCadastroLinha : System.Web.UI.Page
    {
        public string strConn;
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
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
            //        cmd.CommandText = @"INSERT INTO Linha(NomeLinha, id_Itinerario, id_Empresa) VALUES ( @NomeLinha, @id_Itinerario , @id_Empresa )";

            //        try
            //        {
            //            cmd.Parameters.AddWithValue("@NomeLinha", txtNomeLinha.Text.ToString());
            //            cmd.Parameters.AddWithValue("@id_Itinerario", txtid_Itinerario.Text.ToString());
            //            cmd.Parameters.AddWithValue("@id_Empresa", txtid_Empresa.Text.ToString());
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
            //        }

            //    }
            //}
            #endregion
            Linha linha = GetData();

            var db = new LinhaCadastroDB();
            if (db.Insert(linha))
            {
                Response.Write("<script language='javascript'>alert('Os dados foram cadastrados com sucesso!');</script>");
                LoadGrid();
            }
            else
                Response.Write("<script language='javascript'>alert('Erro!\n\n Os dados não foram cadastrados verifique se os campos estão corretos.');</script>");
        }
        public Linha GetData()
        {
            return new Linha()
            {
                NomeLinha = txtNomeLinha.Text.ToString(),
                id_Itinerario = int.Parse(txtid_Itinerario.Text.ToString()),

            };
        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dgvLinha.DataSource = new LinhaCadastroDB().GetAll();
            dgvLinha.DataBind();
        }

        protected void btnConsultarItinerario_Click(object sender, EventArgs e)
        {
            dgvLinha.DataSource = new ItinerarioCadastroDB().GetAll();
            dgvLinha.DataBind();
        }
    }
}
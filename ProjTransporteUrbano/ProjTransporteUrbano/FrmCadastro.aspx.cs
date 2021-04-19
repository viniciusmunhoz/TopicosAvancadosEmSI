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
    public partial class FrmCadastro : System.Web.UI.Page
    {
        public string strConn;
        DataTable dt = new DataTable();

        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            strConn = ("Data Source=BR-PF1CDNKU\\SQLEXPRESS;Initial Catalog=DB_P2;Integrated Security=true");

        }

        public void Button1_Click(object sender, EventArgs e)
        {
            #region ExecutaComando
            //using (SqlConnection conn = new SqlConnection(strConn))
            //{
            //    using (SqlCommand cmd = new SqlCommand())
            //    {
            //        cmd.Connection = conn;
            //        cmd.CommandType = CommandType.Text;
            //        cmd.CommandText = @"INSERT INTO TESTE(NomeEmpresa, Endereco, Telefone, Site, id_Cidade) VALUES ( @NomeEmpresa, @Endereco , @Telefone, @Site, @id_Cidade )";

            //        try
            //        {
            //            cmd.Parameters.AddWithValue("@NomeEmpresa", txtNomeEmpresa.Text.ToString());
            //            cmd.Parameters.AddWithValue("@Endereco", txtEndereco.Text.ToString());
            //            cmd.Parameters.AddWithValue("@Telefone", txtTelefone.Text.ToString());
            //            cmd.Parameters.AddWithValue("@Site", txtSiteEmpresa.Text.ToString());
            //            cmd.Parameters.AddWithValue("@id_Cidade", txtIdCidade.Text.ToString());
            //        }
            //        catch (SqlException ex)
            //        {
            //            Response.Write("<script>alert('Os dados não foram cadastrados verifique o erro:'" + ex.Message.ToString() + ");</script>");
            //            return;
            //        }
            //        try
            //        {
            //            conn.Open();
            //            cmd.ExecuteNonQuery();
            //            conn.Close();
            //            Response.Write("<script>alert('Os dados foram cadastrados com sucesso');</script>");
            //        }
            //        catch (SqlException ex)
            //        {
            //            Response.Write("<script>alert('Os dados não foram cadastrados verifique o erro'" + ex.Message.ToString() + ");</script>");
            //            return;
            //        }
            //        cmd.CommandText = @"SELECT * FROM TESTE";
            //        conn.Open();

            //    }
            //}
            #endregion
            lblResultado.Text = "";
            Empresa empresa = GetData();

            var db = new EmpresaCadastroDB();
            if (db.Insert(empresa))
            {
                Response.Write("<script language='javascript'>alert('Os dados foram cadastrados com sucesso!');</script>");
                LoadGrid();
            }
            else
                Response.Write("<script language='javascript'>alert('Erro!\n\n Os dados não foram cadastrados verifique se os campos estão corretos.');</script>");

        }
        public Empresa GetData()
        {
            return new Empresa()
            {

                NomeEmpresa = txtNomeEmpresa.Text.ToString(),
                Endereco = txtEndereco.Text.ToString(),
                Telefone = txtTelefone.Text.ToString(),
                Site = txtSiteEmpresa.Text.ToString(),
                id_Cidade = int.Parse(txtIdCidade.Text.ToString()),
            };

        }

        protected void btnConsulta_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            if (txtConsultaPorNome.Text.ToString() != "")
            {
                LoadGridNomeEmpresas();
            }
            else
                LoadGrid();
        }

        private void LoadGrid()
        {
            dgvEmpresa.DataSource = new EmpresaCadastroDB().GetAll();
            dgvEmpresa.DataBind();
        }

        private void LoadGridNomeEmpresas()
        {
            dgvEmpresa.DataSource = new EmpresaCadastroDB().GetNomeEmpresas(txtConsultaPorNome.Text.ToString());
            dgvEmpresa.DataBind();
            if (dgvEmpresa.Rows.Count <= 0)
            {
                Response.Write("<script language='javascript'>alert('Nenhuma empresa foi encontrada com esse nome, por favor verifique..');</script>");
            }
            else
                lblResultado.Text = "Resultados: " + dgvEmpresa.Rows.Count.ToString();
        }

        protected void btnConsultarLinha_Click(object sender, EventArgs e)
        {
            dgvEmpresa.DataSource = new LinhaCadastroDB().GetAll();
            dgvEmpresa.DataBind();
        }
    }
}
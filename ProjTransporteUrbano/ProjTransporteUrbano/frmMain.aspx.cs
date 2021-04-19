using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dal;
using Model;

namespace ProjTransporteUrbano
{
    public partial class frmMain : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnCadastroEmpresa_Click(object sender, EventArgs e)
        {

        }

        protected void btnCadastroCidade_Click(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void btnConsultaLinha_Click(object sender, EventArgs e)
        {
            if (txtNomeEmpresa.Text == "")
            {
                Response.Write("<script language='javascript'>alert('O campo está vazio, verifique..');</script>");
                txtNomeEmpresa.Focus();
                return;
            } 
            dgvMain.DataSource = new LinhacomEmpresaCadastroDB().GetNomeLinha(txtNomeEmpresa.Text.ToString());
            dgvMain.DataBind();
            dgvMain.Rows.Count.ToString();
            lblResultado.Text = "Resultado: "+dgvMain.Rows.Count.ToString();

            if (dgvMain.Rows.Count <= 0)
                Response.Write("<script language='javascript'>alert('Nenhum registro encontrado.');</script>");
            return;
        }

        protected void btnConsultaItinerario_Click(object sender, EventArgs e)
        {
            if (txtNomeLinha.Text == "")
            {
                Response.Write("<script language='javascript'>alert('O campo está vazio, verifique..');</script>");
                txtNomeLinha.Focus();
                return;
            }
            dgvMain.DataSource = new ItinerariocomLinhaCadastroDB().GETALL(txtNomeLinha.Text.ToString());
            dgvMain.DataBind();
            lblResultado.Text = "Resultado: " + dgvMain.Rows.Count.ToString();
            if (dgvMain.Rows.Count <= 0)
                Response.Write("<script language='javascript'>alert('Nenhum registro encontrado.');</script>");
            return;
        }

        protected void btnConsultaQuadroHorario_Click(object sender, EventArgs e)
        {
            if (TxtNomelinhaQuadro.Text == "")
            {
                Response.Write("<script language='javascript'>alert('O campo está vazio, verifique..');</script>");
                TxtNomelinhaQuadro.Focus();
                return;
            }
            dgvMain.DataSource = new LinhaCadastroDB().GetNomeLinha(TxtNomelinhaQuadro.Text.ToString());
            dgvMain.DataBind();
            lblResultado.Text = "Resultado: " + dgvMain.Rows.Count.ToString();
            if (dgvMain.Rows.Count <= 0)
                Response.Write("<script language='javascript'>alert('Nenhum registro encontrado.');</script>");
            return;
        }

        protected void btnConsultaPorLogradouro_Click(object sender, EventArgs e)
        {
            if (txtNomeLogradouro.Text == "")
            {
                Response.Write("<script language='javascript'>alert('O campo está vazio, verifique..');</script>");
                txtNomeLogradouro.Focus();
                return;
            }
            dgvMain.DataSource = new ItinerariocomLinhaCadastroDB().GETALLGETALLLOGRADOURO(txtNomeLogradouro.Text.ToString());
            dgvMain.DataBind();
            lblResultado.Text = "Resultado: " + dgvMain.Rows.Count.ToString();
            if (dgvMain.Rows.Count <= 0)
                Response.Write("<script language='javascript'>alert('Nenhum registro encontrado.');</script>");
            return;
        }
    }
}
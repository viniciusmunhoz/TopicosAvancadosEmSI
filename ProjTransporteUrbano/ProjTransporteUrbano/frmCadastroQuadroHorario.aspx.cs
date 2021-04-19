using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Dal;

using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Design;
using System.Reflection;
using System.Runtime;
using System.Runtime.InteropServices;

namespace ProjTransporteUrbano
{
    public partial class frmCadastroQuadroHorario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }

        public QuadroHorario GetData()
        {
            return new QuadroHorario()
            {
                DiasUteis = txtDiasUteis.Text.ToString(),
                Sabados = txtSabado.Text.ToString(),
                Domingos = txtDomingos.Text.ToString(),
                Feriados = txtFeriados.Text.ToString(),
                id_Linha = int.Parse(txtid_linha.Text.ToString())
            };
        }
        private void LoadGrid()
        {
            dgvQuadroHorario.DataSource = new ItinerarioCadastroDB().GetAll();
            dgvQuadroHorario.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            QuadroHorario quadroHorario = GetData();

            var db = new QuadroHorarioCadastroDB();
            if (db.Insert(quadroHorario))
            {
                Response.Write("<script language='javascript'>alert('Os dados foram cadastrados com sucesso!');</script>");
                LoadGrid();
            }
            else
                Response.Write("<script language='javascript'>alert('Erro!\n\n Os dados não foram cadastrados verifique se os campos estão corretos.');</script>");
        }

        protected void btnConsultarLinha_Click(object sender, EventArgs e)
        {
            lblResultado.Text = "";
            if (txtConsultaLinha.Text.ToString() != "")
            {
                LoadGridNomeLinha();
            }
            else
                dgvQuadroHorario.DataSource = new LinhaCadastroDB().GetAll();
            dgvQuadroHorario.DataBind();

            //Oculta linha do grid caso não seja join com a tabela Linha  ===  Porem não deu certo :(
            //dgvQuadroHorario.Columns[0].Visible = true;
            //dgvQuadroHorario.Columns[1].Visible = true;

            //dgvQuadroHorario.Columns[2].Visible = false;
            //dgvQuadroHorario.Columns[3].Visible = false;
            //dgvQuadroHorario.Columns[4].Visible = false;
            //dgvQuadroHorario.Columns[5].Visible = false;
            //dgvQuadroHorario.Columns[6].Visible = false;

        }

        private void LoadGridNomeLinha()
        {
            dgvQuadroHorario.DataSource = new LinhaCadastroDB().GetNomeLinha(txtConsultaLinha.Text.ToString());
            dgvQuadroHorario.DataBind();
            if (dgvQuadroHorario.Rows.Count <= 0)
            {
                Response.Write("<script language='javascript'>alert('Nenhuma empresa foi encontrada com esse nome, por favor verifique..');</script>");
            }
            else
                lblResultado.Text = "Resultados: " + dgvQuadroHorario.Rows.Count.ToString();
        }
    }

}
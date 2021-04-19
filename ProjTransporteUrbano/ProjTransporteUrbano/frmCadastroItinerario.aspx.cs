using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Model;
using Dal;

namespace ProjTransporteUrbano
{
    public partial class frmCadastroItinerario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            InitializeCulture();
            //LoadGrid();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Itinerario itinerario = GetData();

            var db = new ItinerarioCadastroDB();
            if (db.Insert(itinerario))
            {
                Response.Write("<script language='javascript'>alert('Os dados foram cadastrados com sucesso!');</script>");
                LoadGrid();
            }
            else
                Response.Write("<script language='javascript'>alert('Erro!\n\n Os dados não foram cadastrados verifique se os campos estão corretos.');</script>");
        }
        public Itinerario GetData()
        {
            return new Itinerario()
            {
                itinerario = txtItinerario.Text.ToString(),
                Sentido = int.Parse(txtSentido.Text.ToString())

            };
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            LoadGrid();
        }
        private void LoadGrid()
        {
            dgvItinerario.DataSource = new ItinerarioCadastroDB().GetAll();
            dgvItinerario.DataBind();
        }

        protected void btnConsultarLinha_Click(object sender, EventArgs e)
        {

            dgvItinerario.DataSource = new LinhaCadastroDB().GetAll();
            dgvItinerario.DataBind();
        }

        protected void btnConsultarLogradouro_Click(object sender, EventArgs e)
        {
            dgvItinerario.DataSource = new LogradouroCadastroDB().GetAll();
            dgvItinerario.DataBind();
        }
    }
}
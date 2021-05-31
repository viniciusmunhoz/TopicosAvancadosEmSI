using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjControleFilmes
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarLista();
        }

        public void CarregarLista()
        {
            FilmesDBEntities context = new FilmesDBEntities();
            List<TB_FILMES> lstFilmes = context.TB_FILMES.ToList<TB_FILMES>();

            DgvFilmes.DataSource = lstFilmes;
            DgvFilmes.DataBind();
        }

        protected void DgvFilmes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idFilme = Convert.ToInt32(e.CommandArgument.ToString());
            FilmesDBEntities contextFilmes = new FilmesDBEntities();
            TB_FILMES filmes = new TB_FILMES();

            filmes = contextFilmes.TB_FILMES.First(c => c.idFilme == idFilme);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("CadastroFilmes.aspx?idFilme=" + idFilme);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextFilmes.TB_FILMES.Remove(filmes);
                contextFilmes.SaveChanges();
                CarregarLista();
                DisplayAlert("Informação", "O Filme foi excluído!", this);
            }
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            //h1.InnerText = titulo;
            //lblMsgPopup.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }
    }
}
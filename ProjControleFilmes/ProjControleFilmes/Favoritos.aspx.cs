using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjControleFilmes
{
    public partial class Favoritos : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            CarregarListaFavoritos();
        }

        private void CarregarListaFavoritos()
        {
            FilmesDBEntities context = new FilmesDBEntities();
            List<TB_FAVORITOS> lstFilmesfavoritos = context.TB_FAVORITOS.ToList<TB_FAVORITOS>();

            DgvFilmes.DataSource = lstFilmesfavoritos;
            DgvFilmes.DataBind();
        }

        protected void DgvFilmes_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idFilme = Convert.ToInt32(e.CommandArgument.ToString());
            FilmesDBEntities contextFilmes = new FilmesDBEntities();
            TB_FAVORITOS filmes = new TB_FAVORITOS();

            filmes = contextFilmes.TB_FAVORITOS.First(c => c.idFilme == idFilme);

            if (e.CommandName == "INCLUIR")
            {
                contextFilmes.TB_FAVORITOS.Add(filmes);
                contextFilmes.SaveChanges();
                CarregarListaFavoritos();
                DisplayAlert("Informação", "O Favorito foi Adicionado!", this);
            }
            if (e.CommandName == "EXCLUIR")
            {
                contextFilmes.TB_FAVORITOS.Remove(filmes);
                contextFilmes.SaveChanges();
                CarregarListaFavoritos();
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

        protected void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            FilmesDBEntities context = new FilmesDBEntities();
            List<TB_FILMES> lstFilmes = context.TB_FILMES.ToList<TB_FILMES>();

            DgvFilmes.DataSource = lstFilmes;
            DgvFilmes.DataBind();
        }
    }
}
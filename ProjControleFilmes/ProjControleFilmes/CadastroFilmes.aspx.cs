using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjControleFilmes
{
    public partial class CadastroFilmes : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                CarregarDadosPagina();
            }
        }

        protected void btnCadastrar_Click(object sender, EventArgs e)
        {
            TB_FILMES filme = new TB_FILMES()
            { 
                Titulo = txtTitulo.Text, 
                Diretor = txtDiretor.Text,
                Genero = txtGenero.Text,
                DataLancamento = Calendario.SelectedDate
            };

            FilmesDBEntities contextFilmes = new FilmesDBEntities();


            if (String.IsNullOrEmpty(Request.QueryString["idFilme"]))
            {
                contextFilmes.TB_FILMES.Add(filme);
                lblmsg.Text = "O Filme foi inserido!";
                LimparComponentes();
            }
            else
            {
                int id = Convert.ToInt32(Request.QueryString["idFilme"]);
                TB_FILMES alterarfilmes = contextFilmes.TB_FILMES.First(c => c.idFilme == id);
                alterarfilmes.Titulo = filme.Titulo;
                alterarfilmes.Diretor = filme.Diretor;
                alterarfilmes.Genero = filme.Genero;
                alterarfilmes.DataLancamento = filme.DataLancamento;
                lblmsg.Text = "As alterações foram realizadas!";
            }
            contextFilmes.SaveChanges();
        }

        private void LimparComponentes()
        {
            txtTitulo.Text = "";
            txtDiretor.Text = "";
            txtGenero.Text = "";
            Calendario.TodaysDate = Calendario.TodaysDate;
            txtTitulo.Focus();
        }

        public void CarregarDadosPagina()
        {
            TB_FILMES filmes = new TB_FILMES();

            if (!String.IsNullOrEmpty(Request.QueryString["idFilme"]))
            {
                FilmesDBEntities contextFilmes = new FilmesDBEntities();
                filmes = contextFilmes.TB_FILMES.First(c => c.idFilme == int.Parse(Request.QueryString["idFilme"]));

                txtTitulo.Text = filmes.Titulo;
                txtDiretor.Text = filmes.Diretor;
                txtGenero.Text = filmes.Genero;
                Calendario.TodaysDate = filmes.DataLancamento.Value;
            }
        }
    }
}
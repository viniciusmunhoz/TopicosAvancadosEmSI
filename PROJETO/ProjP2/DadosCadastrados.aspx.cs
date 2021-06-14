using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjP2
{
    public partial class DadosCadastrados : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        string titulo = "";
        string msg = "";

        protected void dgvDadosCadastrados_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int idItem = Convert.ToInt32(e.CommandArgument.ToString());
            DBRelacaoAlunosEntities contextAlunos = new DBRelacaoAlunosEntities();
            TB_AlunosDiplomados alunosDiplomados = new TB_AlunosDiplomados();

            alunosDiplomados = contextAlunos.TB_AlunosDiplomados.First(c => c.Id_aluno == idItem);

            if (e.CommandName == "ALTERAR")
            {
                Response.Redirect("ImportPlanilha.aspx?idItem=" + idItem);
            }
            else if (e.CommandName == "EXCLUIR")
            {
                contextAlunos.TB_AlunosDiplomados.Remove(alunosDiplomados);
                contextAlunos.SaveChanges();
                titulo = "Mensagem";
                msg = "Registro excluído com sucesso !";
                CarregarLista();
                DisplayAlert(titulo, msg, this);
            }
        }

        private void CarregarLista()
        {
            DBRelacaoAlunosEntities context = new DBRelacaoAlunosEntities();
            List<TB_AlunosDiplomados> lstAlunosDiplomados = context.TB_AlunosDiplomados.ToList<TB_AlunosDiplomados>();

            dgvDadosCadastrados.DataSource = lstAlunosDiplomados;
            dgvDadosCadastrados.DataBind();
        }

        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            Label1.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }

        protected void btnMostrarDados_Click(object sender, EventArgs e)
        {
            CarregarLista();
            dgvDadosCadastrados.Visible = true;
        }
    }
}
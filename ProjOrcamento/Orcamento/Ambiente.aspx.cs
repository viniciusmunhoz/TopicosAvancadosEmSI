using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orcamento
{
    public partial class Ambiente : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Model.Ambiente ambiente = getData();
            var db = new AmbienteDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(ambiente))
                {
                    LblMsg.Text = "O registro foi inserido com sucesso!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "O registro não foi inserido..";
            }
            else
            {
                if (db.Update(ambiente, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "O registro foi atualizado com sucesso!";
                }
                else
                    LblMsg.Text = "Ocorreu um erro ao atualizar o registro..";
            }

            LoadGrid();
        }

        private Model.Ambiente getData()
        {
            return new Model.Ambiente()
            {
                Descricao = TxtDescricao.Text,
            };
        }

        private void LoadGrid()
        {
            DgvAmbiente.DataSource = new AmbienteDB().GetAll();
            DgvAmbiente.DataBind();
        }

        protected void DgvAmbiente_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = DgvAmbiente.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new AmbienteDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Model.Ambiente ambiente = db.SelectById(id);

                TxtDescricao.Text = ambiente.Descricao;
                IdH.Value = ambiente.id_Ambiente.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            TxtDescricao.Text = "";
            IdH.Value = "0";
            TxtDescricao.Focus();
        }
    }
}
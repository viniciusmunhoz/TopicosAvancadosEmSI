using Dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Orcamento
{
    public partial class Modulo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LoadGrid();
        }

        protected void BtnSalvar_Click(object sender, EventArgs e)
        {
            Model.Modulo modulo = getData();
            var db = new ModuloDB();

            if ((IdH.Value == "0") || (IdH.Value == ""))
            {
                if (db.Insert(modulo))
                {
                    LblMsg.Text = "O registro foi inserido com sucesso!";
                    LoadGrid();
                }
                else
                    LblMsg.Text = "Erro o registro não foi inserido..";
            }
            else
            {
                if (db.Update(modulo, int.Parse(IdH.Value)))
                {
                    LblMsg.Text = "O registro foi atualizado com sucesso!";
                }
                else
                    LblMsg.Text = "Ocorreu um erro ao atualizar o registro..";
            }

            LoadGrid();
        }

        private Model.Modulo getData()
        {
            return new Model.Modulo()
            {
                Ambiente = int.Parse(cmbAmbiente.Text),
                Squad = int.Parse(cmbSquad.Text),
            };
        }

        private void LoadGrid()
        {
            dgvModulo.DataSource = new ModuloDB().GetAll();
            dgvModulo.DataBind();
        }

        protected void dgvModulo_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int index = Convert.ToInt32(e.CommandArgument);
            GridViewRow row = dgvModulo.Rows[index];

            int id = Convert.ToInt32(row.Cells[0].Text);

            var db = new ModuloDB();

            if (e.CommandName == "Excluir")
            {
                db.Delete(id);
                LoadGrid();

            }
            else if (e.CommandName == "Editar")
            {
                Model.Modulo modulo = db.SelectById(id);

                cmbAmbiente.Text = modulo.Ambiente.ToString();
                cmbSquad.Text = modulo.Squad.ToString();
                IdH.Value = modulo.id_Modulo.ToString();
            }
        }

        protected void btnNovo_Click(object sender, EventArgs e)
        {
            IdH.Value = "0";
            cmbAmbiente.Focus();
        }
    }
}
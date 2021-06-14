using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace ProjP2
{
    public partial class ImportPlanilha : System.Web.UI.Page
    {
        private string BulkPath = "";
        private string BulkSheet = "";
        private string nomePlanilha = "";
        private DataTable dtRetorno = null;
        private OleDbConnection excelConnection;
        string msg = "";
        string titulo = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnImport_Click(object sender, EventArgs e)
        {
            if (ImportDataFromExcel(@"C:\DB_FACULDADE\ProjetoRelacaoAlunos\PROJETO\RelacaoAlunosDiplomados.xls"))
            {
                titulo = "Mensagem";
                msg = "Planilha importada com sucesso!";
                DisplayAlert(titulo, msg, this);
            }
        }



        public bool ImportDataFromExcel(string excelFilePath)
        {
            //declare variáveis ​​-edite -as com base em sua situação particular
            string ssqltable = "TB_AlunosDiplomados";

            // Nome da sheet dentro da planilha.
            string myexceldataquery = "select * from [sheet1$]";
            try
            {
                // string de conexão
                string sexcelconnectionstring = @"provider=microsoft.jet.oledb.4.0;data source=" + excelFilePath +
                ";extended properties=" + "\"excel 8.0;hdr=yes;\"";
                string ssqlconnectionstring = @"Data Source=BR-PF1CDNKU\SQLEXPRESS;Initial Catalog=DBRelacaoAlunos;Integrated Security=True";

                //execute uma consulta para apagar quaisquer dados anteriores de nossa tabela de destino
                string sclearsql = "delete from " + ssqltable;
                SqlConnection sqlconn = new SqlConnection(ssqlconnectionstring);
                SqlCommand sqlcmd = new SqlCommand(sclearsql, sqlconn);
                sqlconn.Open();
                sqlcmd.ExecuteNonQuery();
                sqlconn.Close();

                //série de comandos para copiar dados em massa do arquivo excel em nossa tabela sql
                OleDbConnection oledbconn = new OleDbConnection(sexcelconnectionstring);
                OleDbCommand oledbcmd = new OleDbCommand(myexceldataquery, oledbconn);
                oledbconn.Open();
                OleDbDataReader dr = oledbcmd.ExecuteReader();
                SqlBulkCopy bulkcopy = new SqlBulkCopy(ssqlconnectionstring);
                bulkcopy.DestinationTableName = ssqltable;
                while (dr.Read())
                {
                    bulkcopy.WriteToServer(dr);
                }
                dr.Close();
                oledbconn.Close();


            }
            catch (Exception ex)
            {
                titulo = "Atenção";
                msg = "Erro: " + ex.Message.ToString();
                DisplayAlert(titulo,msg, this);
                return false;
            }
            return true;
        }
        public void DisplayAlert(string titulo, string mensagem, System.Web.UI.Page page)
        {
            h1.InnerText = titulo;
            Label1.InnerText = mensagem;
            ClientScript.RegisterStartupScript(typeof(Page), Guid.NewGuid().ToString(),
                "MostrarPopupMensagem();", true);
        }
    }
}
<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="DadosCadastrados.aspx.cs" Inherits="ProjP2.DadosCadastrados" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            border-collapse: collapse;
            max-width: 100%;
            margin-bottom: 20px;
        }

        .auto-style2 {
            overflow: auto;
            width: 1329px;
            height: 536px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript"> function MostrarPopupMensagem() { $("#modalMsg").modal('show'); }
        function EsconderPopupDados() { $("#modalDados").modal('hide'); } </script>
    <!-- /.modal -->
    <div class="modal fade" id="modalMsg">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                    <h4 class="modal-title" id="h1" runat="server">Modal title</h4>
                </div>
                <div class="modal-body">
                    <p>
                        <label id="Label1" runat="server"></label>
                    </p>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Ok</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>

    <form id="form1" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2><a href="#">Dados Cadastrados</a> <span></span></h2>
                    <p>
                        <asp:Label ID="lblMsgPopup" runat="server"></asp:Label>
                    </p>
                </div>
            </div>
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2>&nbsp;<asp:Button class="btn btn-primary" ID="btnMostrarDados" runat="server" Text="Mostrar relação de alunos" OnClick="btnMostrarDados_Click" Width="205px" />&nbsp;
                    <p>
                        &nbsp;
                    </p>
                        <div class="auto-style2">
                            <asp:GridView ID="dgvDadosCadastrados" runat="server" CellPadding="4" CssClass="auto-style2" ForeColor="Black" OnRowCommand="dgvDadosCadastrados_RowCommand" Height="529px" Width="1314px" Visible="False" CellSpacing="5" Font-Size="Small" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px">
                                <FooterStyle BackColor="#CCCCCC" />
                                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" HorizontalAlign="Right" VerticalAlign="Middle" />
                                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" VerticalAlign="Middle" />
                                <RowStyle BackColor="White" HorizontalAlign="Justify" VerticalAlign="Middle" />
                                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                                <SortedAscendingHeaderStyle BackColor="#808080" />
                                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                                <SortedDescendingHeaderStyle BackColor="#383838" />
                                <Columns>
                                    <asp:TemplateField HeaderText="Ações">
                                        <ItemTemplate>
                                            <asp:LinkButton runat="server" ID="btnAlterarMidia" CommandName="ALTERAR" CommandArgument='<%# Eval("Id_Aluno") %>' CssClass="btn btn btn-info" Text="Alterar" BackColor="#00CC66" />
                                            <asp:LinkButton runat="server" ID="btnExcluirMidia" CommandName="EXCLUIR" CommandArgument='<%# Eval("Id_Aluno") %>' CssClass="btn btn btn-primary" Text="Excluir" BackColor="Red" />&nbsp;
                                        </ItemTemplate>
                                    </asp:TemplateField>
                                </Columns>
                            </asp:GridView>
                        </div>
                    </h2>
                    <p>
                        &nbsp;
                    </p>
                </div>
            </div>
        </article>

    </form>
</asp:Content>

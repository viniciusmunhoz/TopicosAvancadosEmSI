<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjControleFilmes.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script type="text/javascript"> function MostrarPopupMensagem() { $("#modalMsg").modal('show'); }
        function EsconderPopupDados() { $("#modalDados").modal('hide'); } </script>
    <!-- /.modal -->
    <form runat="server">
    <div class="modal fade" id="modalMsg">
        <div class="modal-dialog">
            <div class="modal-content">
                <div class="modal-header">
                    <button type="button" class="close" data-dismiss="modal"><span aria-hidden="true">&times;</span><span class="sr-only">Close</span></button>
                    <h4 class="modal-title" id="h1" runat="server">Alterar ou Excluir Filmes</h4>
                </div>
                <div class="modal-footer">
                    <button type="button" class="btn btn-danger" data-dismiss="modal">Ok</button>
                </div>
            </div>
            <!-- /.modal-content -->
        </div>
        <!-- /.modal-dialog -->
    </div>
        <asp:GridView ID="DgvFilmes" runat="server" CellPadding="4" CssClass="table" OnRowCommand="DgvFilmes_RowCommand" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Width="673px">
            <Columns>
                <asp:TemplateField HeaderText="Ações">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnAlterarMidia" CommandName="ALTERAR" CommandArgument='<%# Eval("IdFilme") %>' CssClass="btn btn btn-info" Text="Alterar" />
                        <asp:LinkButton runat="server" ID="btnExcluirMidia" CommandName="EXCLUIR" CommandArgument='<%# Eval("IdFilme") %>' CssClass="btn btn btn-primary" Text="Excluir" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </form>
</asp:Content>

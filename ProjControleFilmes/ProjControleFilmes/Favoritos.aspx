<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="Favoritos.aspx.cs" Inherits="ProjControleFilmes.Favoritos" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form runat="server">
        <h4 class="modal-title" id="h1" runat="server">Filmes Favoritos</h4>
        <p class="modal-title" runat="server">
            <asp:Button ID="btnFavoritos" runat="server" Text="Favoritos" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnMostrarTodos" runat="server" OnClick="btnMostrarTodos_Click" Text="Mostrar Todos" />
        </p>
        <asp:GridView ID="DgvFilmes" runat="server" CellPadding="4" CssClass="table" OnRowCommand="DgvFilmes_RowCommand" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" Width="673px" OnLoad="Page_Load" OnSelectedIndexChanged="DgvFilmes_SelectedIndexChanged">
            <Columns>
                <asp:TemplateField HeaderText="Ações">
                    <ItemTemplate>
                        <asp:LinkButton runat="server" ID="btnIncluirMidia" CommandName="INCLUIR" CommandArgument='<%# Eval("IdFilme") %>' CssClass="btn btn btn-info" Text="Incluir Favorito" />
                        <asp:LinkButton runat="server" ID="btnExcluirMidia" CommandName="EXCLUIR" CommandArgument='<%# Eval("IdFilme") %>' CssClass="btn btn btn-primary" Text="Excluir Favorito" />
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
        <asp:Label ID="lblMsgPopup" runat="server"></asp:Label>
    </form>
</asp:Content>

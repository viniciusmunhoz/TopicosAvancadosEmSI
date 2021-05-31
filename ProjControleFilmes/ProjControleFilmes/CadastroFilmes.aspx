<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="CadastroFilmes.aspx.cs" Inherits="ProjControleFilmes.CadastroFilmes" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <link rel="stylesheet" href="http://code.jquery.com/ui/1.9.0/themes/base/jquery-ui.css" />
    <script src="http://code.jquery.com/jquery-1.8.2.js"></script>
    <script src="http://code.jquery.com/ui/1.9.0/jquery-ui.js"></script>

    <form id="form1" runat="server">
        <article class="kanban-entry grab" id="item1" draggable="true">
            <div class="kanban-entry-inner">
                <div class="kanban-label">
                    <h2>Cadastro de Filmes </h2>
                    <p></p>
                </div>
            </div>
        </article>
        <div class="form-group">
            Titulo<label for="descricao">:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </label>
&nbsp;<asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="form-group">
            Diretor<label for="Preco">:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" name="txtPreco" ID="txtDiretor" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="form-group">
            Genero<label for="Cor">:</label>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox class="form-control" name="txtCor" ID="txtGenero" runat="server"></asp:TextBox>
            <br />
            <br />
        </div>
        <div class="form-group">
            Data de lancamento<label for="Tamanho">:</label>
            <asp:Calendar ID="Calendario" runat="server" BackColor="White" BorderColor="White" BorderWidth="1px" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="190px" NextPrevFormat="FullMonth" Width="350px">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" VerticalAlign="Bottom" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="White" BorderColor="Black" BorderWidth="4px" Font-Bold="True" Font-Size="12pt" ForeColor="#333399" />
                <TodayDayStyle BackColor="#CCCCCC" />
            </asp:Calendar>
        </div>
        <asp:Button class="btn btn-primary" ID="btnCadastrar" runat="server" Text="Salvar" OnClick="btnCadastrar_Click" />
    </form>
    <br />
<% if (!String.IsNullOrEmpty(lblmsg.Text))
        {%>
    <div class="alert alert-success"><a href="#" class="close" data-dismiss="alert" aria-label="close">&times;</a> <strong>
        <asp:Label ID="lblmsg" runat="server" Text=""></asp:Label></strong> </div>
<%} %>
</asp:Content>

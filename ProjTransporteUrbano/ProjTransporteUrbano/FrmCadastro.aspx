<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FrmCadastro.aspx.cs" Inherits="ProjTransporteUrbano.FrmCadastro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style13 {
            margin-left: 0px;
        }
        .auto-style20 {
            width: 84%;
            height: 271px;
            margin-bottom: 0px;
        }
        .auto-style22 {
            height: 54px;
            width: 273px;
        }
        .auto-style23 {
            width: 273px;
        }
        .auto-style24 {
            height: 28px;
            width: 273px;
        }
        .auto-style25 {
            height: 54px;
            width: 295px;
        }
        .auto-style26 {
            width: 295px;
        }
        .auto-style27 {
            height: 28px;
            width: 295px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style20">
            <tr>
                <td class="auto-style25">
                    <asp:Label ID="lblCadastroEmpresa" runat="server" BackColor="Black" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="CADASTRAR EMPRESA"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="btnVoltar" runat="server" Font-Bold="True" Height="29px" PostBackUrl="~/frmMain.aspx" Text="Voltar" Width="136px" CssClass="auto-style13" />
                </td>
                <td class="auto-style22">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">Digite o nome da empresa:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style23">&nbsp;</td>
                <td class="auto-style23">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    <asp:TextBox ID="txtNomeEmpresa" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style23">
                    <asp:Button ID="btnCadastrar" runat="server" Font-Bold="True" Height="34px" OnClick="Button1_Click" Text="Cadastrar" Width="134px" />
                </td>
                <td class="auto-style23">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">Digite o Endereço:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style24" id="dgvEmpresa">
                    &nbsp;</td>
                <td class="auto-style24" id="dgvEmpresa">
                    Consulta por nome da empresa?</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:TextBox ID="txtEndereco" runat="server" BackColor="#CCFFCC" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnConsulta" runat="server" Height="32px" OnClick="btnConsulta_Click" Text="Consultar" Width="134px" Font-Bold="True" />
                &nbsp;&nbsp;&nbsp;&nbsp;
                </td>
                <td class="auto-style24">
                    <asp:TextBox ID="txtConsultaPorNome" runat="server" Width="193px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style27">Digite o Telefone:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:TextBox ID="txtTelefone" runat="server" BackColor="#CCFFFF" CssClass="auto-style13" Width="161px"></asp:TextBox>
                </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">Site da empresa:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:TextBox ID="txtSiteEmpresa" runat="server" BackColor="#CCFFCC" Width="162px"></asp:TextBox>
                </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">Código da cidade:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style24">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:TextBox ID="txtIdCidade" runat="server" BackColor="#CCFFFF" Width="164px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    id_Linha</td>
                <td class="auto-style24">
                    &nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style27">
                    <asp:TextBox ID="txtid_Linha" runat="server" BackColor="#CCFFCC" Width="162px"></asp:TextBox>
                </td>
                <td class="auto-style24">
                    <asp:Button ID="btnConsultarLinha" runat="server" OnClick="btnConsultarLinha_Click" Text="Consultar Linhas" />
                </td>
                <td class="auto-style24">
                    <asp:Label ID="lblResultado" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
        <asp:GridView ID="dgvEmpresa" runat="server" Height="120px" Width="1162px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
            <AlternatingRowStyle BackColor="White" />
            <FooterStyle BackColor="#CCCC99" />
            <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
            <RowStyle BackColor="#F7F7DE" />
            <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#FBFBF2" />
            <SortedAscendingHeaderStyle BackColor="#848384" />
            <SortedDescendingCellStyle BackColor="#EAEAD3" />
            <SortedDescendingHeaderStyle BackColor="#575357" />
        </asp:GridView>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadastroLogradouro.aspx.cs" Inherits="ProjTransporteUrbano.frmCadastroLogradouro" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style20 {
            width: 44%;
            height: 271px;
            margin-bottom: 0px;
        }
        .auto-style25 {
            height: 54px;
            width: 523px;
        }
        .auto-style22 {
            height: 54px;
            width: 273px;
        }
        .auto-style26 {
            width: 523px;
        }
        .auto-style23 {
            width: 273px;
        }
        .auto-style24 {
            height: 28px;
            width: 273px;
        }
        .auto-style28 {
            height: 28px;
            width: 523px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style20">
            <tr>
                <td class="auto-style25">
                    <asp:Label ID="lblCadastroEmpresa" runat="server" BackColor="Black" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="CADASTRAR LOGRADOURO"></asp:Label>
                </td>
                <td class="auto-style22">
                    <asp:Button ID="btnVoltar" runat="server" Font-Bold="True" Height="29px" PostBackUrl="~/frmMain.aspx" TabIndex="50" Text="Voltar" Width="136px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style26">Digite o nome do logradouro:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                <td class="auto-style23">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style26">
                    <asp:TextBox ID="txtNomeLogradouro" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                </td>
                <td class="auto-style23">
                    <asp:Button ID="btnCadastrar" runat="server" Font-Bold="True" Height="34px" OnClick="Button1_Click" Text="Cadastrar" Width="134px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style28">Digite o DDD da cidade:</td>
                <td>
                    <asp:Button ID="btnConsultar" runat="server" Font-Bold="True" Height="28px" OnClick="btnConsultar_Click" Text="Consultar" Width="134px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style28">
                    <asp:TextBox ID="txtid_Cidade" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style28">&nbsp;</td>
                <td class="auto-style24">&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
        <asp:GridView ID="dgvLogradouro" runat="server" Height="120px" Width="1162px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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

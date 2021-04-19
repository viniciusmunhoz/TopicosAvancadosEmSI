<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadastroItinerario.aspx.cs" Inherits="ProjTransporteUrbano.frmCadastroItinerario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style20 {
            width: 77%;
            height: 271px;
            margin-bottom: 0px;
        }
        .auto-style25 {
            height: 54px;
            width: 958px;
        }
        .auto-style22 {
            height: 54px;
            width: 273px;
        }
        .auto-style26 {
            width: 958px;
        }
        .auto-style23 {
            width: 273px;
        }
        .auto-style28 {
            height: 28px;
            width: 958px;
        }
        .auto-style29 {
            height: 39px;
            width: 273px;
        }
        .auto-style30 {
            height: 39px;
            width: 958px;
        }
        .auto-style31 {
            height: 54px;
            width: 1072px;
        }
        .auto-style32 {
            width: 1072px;
        }
        .auto-style33 {
            height: 28px;
            width: 1072px;
        }
        .auto-style34 {
            height: 39px;
            width: 1072px;
        }
        .auto-style35 {
            height: 40px;
            width: 1072px;
        }
        .auto-style36 {
            height: 40px;
            width: 958px;
        }
        .auto-style37 {
            height: 40px;
            width: 273px;
        }
        .auto-style38 {
            height: 45px;
            width: 1072px;
        }
        .auto-style39 {
            height: 45px;
            width: 958px;
        }
        .auto-style40 {
            height: 45px;
            width: 273px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style20">
                <tr>
                    <td class="auto-style31">
                        <asp:Label ID="lblCadastroEmpresa" runat="server" BackColor="Black" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="CADASTRAR ITINERÁRIOS"></asp:Label>
                    </td>
                    <td class="auto-style25">
                        &nbsp;</td>
                    <td class="auto-style22">
                        <asp:Button ID="btnVoltar" runat="server" Font-Bold="True" Height="29px" PostBackUrl="~/frmMain.aspx" Text="Voltar" Width="136px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style32">Digite os ids dos logradouros em sequencia separados por virgula:&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td class="auto-style26">
                        <asp:Button ID="btnConsultarLogradouro" runat="server" Font-Bold="True" Height="25px" OnClick="btnConsultarLogradouro_Click" Text="Consultar Logradouros" Width="156px" />
                    </td>
                    <td class="auto-style23">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style35">
                        <asp:TextBox ID="txtItinerario" runat="server" BackColor="#CCFFFF" Width="209px"></asp:TextBox>
                    &nbsp;Exemplo:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 1,2,3</td>
                    <td class="auto-style36">
                        &nbsp;</td>
                    <td class="auto-style37">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style33">Digite o id do logradouro para o sentido do itinerário:</td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style23">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style38">
                        <asp:TextBox ID="txtSentido" runat="server" BackColor="#CCFFCC" Width="203px" MaxLength="2"></asp:TextBox>
                    </td>
                    <td class="auto-style39">
                        <asp:Button ID="btnCadastrar" runat="server" Font-Bold="True" Height="35px" OnClick="Button1_Click" Text="Cadastrar" Width="146px" />
                    </td>
                    <td class="auto-style40">
                        <asp:Button ID="btnConsultarLinha" runat="server" Font-Bold="True" Height="30px" OnClick="btnConsultarLinha_Click" Text="Consultar Linhas" Width="161px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td class="auto-style28">
                        &nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style34">
                        &nbsp;</td>
                    <td class="auto-style30">&nbsp;</td>
                    <td class="auto-style29">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style33">
                        &nbsp;</td>
                    <td class="auto-style28">
                        &nbsp;</td>
                    <td class="auto-style23">
                        <asp:Button ID="btnConsultar" runat="server" Font-Bold="True" Height="33px" OnClick="btnConsultar_Click" Text="Consultar Itinários" Width="160px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style33">&nbsp;</td>
                    <td class="auto-style28">&nbsp;</td>
                    <td class="auto-style23"></td>
                </tr>
                </table>
        <div>
        </div>
        <asp:GridView ID="dgvItinerario" runat="server" Height="120px" Width="1162px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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

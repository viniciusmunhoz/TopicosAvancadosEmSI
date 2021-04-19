<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmCadastroQuadroHorario.aspx.cs" Inherits="ProjTransporteUrbano.frmCadastroQuadroHorario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

        .auto-style20 {
            width: 109%;
            height: 271px;
            margin-bottom: 0px;
        }
        .auto-style22 {
            height: 54px;
            width: 450px;
        }
        .auto-style23 {
            width: 450px;
        }
        .auto-style28 {
            height: 28px;
            width: 450px;
        }
        .auto-style29 {
            height: 54px;
            width: 488px;
        }
        .auto-style30 {
            width: 488px;
        }
        .auto-style31 {
            height: 28px;
            width: 488px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
            <table class="auto-style20">
                <tr>
                    <td class="auto-style29">
                        <asp:Label ID="lblCadastroEmpresa" runat="server" BackColor="Black" Font-Bold="True" Font-Size="Larger" ForeColor="White" Text="CADASTRO DE QUADRO DE HORARIOS"></asp:Label>
                    </td>
                    <td class="auto-style22">
                        <asp:Button ID="btnVoltar" runat="server" Font-Bold="True" Height="29px" PostBackUrl="~/frmMain.aspx" TabIndex="50" Text="Voltar" Width="136px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style30">Digite o quadro de horarios dos dias uteis:&nbsp;&nbsp; </td>
                    <td class="auto-style23">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style30">
                        <asp:TextBox ID="txtDiasUteis" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                    </td>
                    <td class="auto-style23">
                        <asp:Button ID="btnCadastrar" runat="server" Font-Bold="True" Height="34px" OnClick="Button1_Click" Text="Cadastrar" Width="134px" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Digite o quadro de horarios aos Sábados:</td>
                    <td class="auto-style23">
                        <asp:Button ID="btnConsultar" runat="server" Height="28px" OnClick="btnConsultar_Click" Text="Consultar" Width="134px" Font-Bold="True" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:TextBox ID="txtSabado" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Digite o quadro de horarios aos Domingos:</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:TextBox ID="txtDomingos" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style31">Digite o quadro de horarios aos Feriados:</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:TextBox ID="txtFeriados" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style31">Digite o id da linha pertencente:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
                    <td>&nbsp; Consultar quadro de horario pelo NOME da Linha?</td>
                </tr>
                <tr>
                    <td class="auto-style31">
                        <asp:TextBox ID="txtid_linha" runat="server" BackColor="#CCFFFF" Width="160px"></asp:TextBox>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Button ID="btnConsultarLinha" runat="server" OnClick="btnConsultarLinha_Click" Text="Consultar Linha" Width="134px" style="height: 26px" />
                    </td>
                    <td class="auto-style28">&nbsp;<asp:TextBox ID="txtConsultaLinha" runat="server" Width="266px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        <div>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lblResultado" runat="server"></asp:Label>
        </div>
        <asp:GridView ID="dgvQuadroHorario" runat="server" Height="120px" Width="1162px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmMain.aspx.cs" Inherits="ProjTransporteUrbano.frmMain" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 339px;
        }
        .auto-style4 {
            width: 325px;
        }
        .auto-style10 {
            width: 223px;
        }
        .auto-style11 {
            width: 325px;
            height: 30px;
        }
        .auto-style12 {
            width: 339px;
            height: 30px;
        }
        .auto-style13 {
            width: 223px;
            height: 30px;
        }
        .auto-style14 {
            width: 100%;
            margin-top: 0px;
        }
        .auto-style15 {
            width: 565px;
        }
        .auto-style16 {
            width: 565px;
            height: 23px;
        }
        .auto-style17 {
            height: 23px;
        }
        .auto-style18 {
            height: 23px;
            width: 298px;
        }
        .auto-style19 {
            width: 298px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="border: thin inset #000000; width: 100%;">
            <tr>
                <td class="auto-style4">&nbsp;</td>
                <td class="auto-style2">
                    <asp:Label ID="lblControledeTransportes" runat="server" BackColor="Black" BorderColor="Black" Font-Bold="True" Font-Size="XX-Large" ForeColor="White" TabIndex="10" Text="Controle de Transportes"></asp:Label>
                </td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Label ID="lblCadastros" runat="server" Font-Bold="True" Font-Size="Larger" Text="Cadastros"></asp:Label>
                </td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style11">
                    <asp:Button ID="btnCadastroEmpresa" runat="server" Height="25px" OnClick="btnCadastroEmpresa_Click" PostBackUrl="~/FrmCadastro.aspx" Text="Cadastro de Empresa" Width="303px" />
                </td>
                <td class="auto-style12">
                    <asp:Button ID="btnCadastroCidade" runat="server" Height="24px" OnClick="btnCadastroCidade_Click" PostBackUrl="~/frmCadastroCidade.aspx" Text="Cadastro de Cidades" Width="303px" />
                </td>
                <td class="auto-style13">
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" PostBackUrl="~/frmCadastroLogradouro.aspx" Text="Cadastrar Logradouro" Width="303px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style10">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    <asp:Button ID="Button2" runat="server" PostBackUrl="~/frmCadastroLinha.aspx" Text="Cadastrar Linha" Width="303px" />
                </td>
                <td class="auto-style2">
                    <asp:Button ID="btnItinerario" runat="server" Text="Cadastro de Itinerário" Width="301px" PostBackUrl="~/frmCadastroItinerario.aspx" />
                </td>
                <td class="auto-style10">
                    <asp:Button ID="btnQuadroHorario" runat="server" Text="Quadro de Horários" Width="303px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4">
                    &nbsp;</td>
                <td class="auto-style2">
                    &nbsp;</td>
                <td class="auto-style10">
                    &nbsp;</td>
            </tr>
        </table>
        <table class="auto-style14">
            <tr>
                <td class="auto-style16">Obter todas as linhas atendidas por uma determinada empresa, dado o nome dessa empresa.</td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtNomeEmpresa" runat="server" BackColor="#99CCFF" Width="286px"></asp:TextBox>
                </td>
                <td class="auto-style17">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnConsultaLinha" runat="server" OnClick="btnConsultaLinha_Click" Text="Consultar " Width="126px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style16"></td>
                <td class="auto-style18"></td>
                <td class="auto-style17"></td>
            </tr>
            <tr>
                <td class="auto-style15">Obter o itinerário de uma determinada linha de ônibus, dado o Nome (Identificação) dessa linha.</td>
                <td class="auto-style19">
                    <asp:TextBox ID="txtNomeLinha" runat="server" BackColor="#66FFFF" Width="286px"></asp:TextBox>
                </td>
                <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnConsultaItinerario" runat="server" OnClick="btnConsultaItinerario_Click" Text="Consultar Itinerário" Width="127px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style15">&nbsp;</td>
                <td class="auto-style19">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">Obter o quadro de horário de uma determinada linha, dado seu Nome.</td>
                <td class="auto-style18">
                    <asp:TextBox ID="TxtNomelinhaQuadro" runat="server" BackColor="#99CCFF" Width="286px"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:Button ID="btnConsultaQuadroHorario" runat="server" OnClick="btnConsultaQuadroHorario_Click" Text="Consultar Quadro de Horários" Width="182px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style16">&nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">Obter as linhas de ônibus/empresa que passam por um determinado logradouro, dado o nome desse logradouro.</td>
                <td class="auto-style18">
                    <asp:TextBox ID="txtNomeLogradouro" runat="server" BackColor="#66FFFF" Width="286px"></asp:TextBox>
                </td>
                <td class="auto-style17">
                    <asp:Button ID="btnConsultaPorLogradouro" runat="server" OnClick="btnConsultaPorLogradouro_Click" Text="Consultar Linhas" Width="182px" />
                </td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    &nbsp;</td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style16">
                    <asp:Label ID="lblResultado" runat="server" Font-Bold="True" Font-Size="Large"></asp:Label>
                </td>
                <td class="auto-style18">&nbsp;</td>
                <td class="auto-style17">&nbsp;</td>
            </tr>
        </table>
        <asp:GridView ID="dgvMain" runat="server" Height="120px" Width="1162px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Vertical">
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

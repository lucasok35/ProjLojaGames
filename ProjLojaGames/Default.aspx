<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ProjLojaGames.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Cadastro Games</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2>CADASTRO DE JOGOS ELETRÔNICOS</h2></div>
        <asp:Label ID="lblTitulo" runat="server" Text="Título:"></asp:Label>
        <br />
        <asp:TextBox ID="txtTitulo" runat="server" Width="240px"></asp:TextBox>
        <br />
        <p>
            <asp:Label ID="lblFabricante" runat="server" Text="Fabricante:"></asp:Label>
        <br />
            <asp:TextBox ID="txtFabricante" runat="server" Width="238px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Faixa Etária:"></asp:Label>
            <br />
            <asp:TextBox ID="txtFaixaEtaria" runat="server" Width="234px"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Plataforma:"></asp:Label>
            <br />
            <asp:DropDownList ID="cboPlataforma" runat="server">
            </asp:DropDownList>
        </p>
    <p>
        <asp:Label ID="lblCategoria" runat="server" Text="Categoria:"></asp:Label>
        <br />
        <asp:DropDownList ID="cboCategoria" runat="server">
        </asp:DropDownList>
    </p>

        <asp:Button ID="btnSalvar" runat="server" OnClick="btnSalvar_Click" Text="Salvar" />
        <br />
        <br />
        <asp:Label ID="lblMsg" runat="server"></asp:Label>
        <br />
        <asp:GridView ID="gvDados" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Width="726px" AutoGenerateColumns="False">
            <AlternatingRowStyle BackColor="White" />
            <Columns>
                <asp:BoundField DataField="IdJogo" HeaderText="IdJogo" />
                <asp:BoundField DataField="Titulo" HeaderText="Titulo" />
                <asp:BoundField DataField="Fabricante" HeaderText="Fabricante" />
                <asp:BoundField DataField="FaixaEtaria" HeaderText="FaixaEtaria" />
                <asp:BoundField DataField="Plataforma.Descricao" HeaderText="Plataforma" />
                <asp:BoundField DataField="Categoria.Descricao" HeaderText="Categoria" />
            </Columns>
            <EditRowStyle BackColor="#2461BF" />
            <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#EFF3FB" />
            <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#F5F7FB" />
            <SortedAscendingHeaderStyle BackColor="#6D95E1" />
            <SortedDescendingCellStyle BackColor="#E9EBEF" />
            <SortedDescendingHeaderStyle BackColor="#4870BE" />
        </asp:GridView>

    </form>
</body>
</html>

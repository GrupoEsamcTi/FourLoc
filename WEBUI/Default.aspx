<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBUI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="height: 33px">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Página Inicial - Pesquisa by:</h2>
    <p style="height: 32px; width: 793px; margin-left: 80px;">
        <asp:Label ID="Label1" runat="server" Text="Nome do Filme"></asp:Label>
&nbsp;<asp:TextBox ID="txtNomeFilme" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Text="Atores"></asp:Label>
&nbsp;<asp:TextBox ID="txtAtores" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label3" runat="server" Text="Gêneros"></asp:Label>
&nbsp;<asp:TextBox ID="txtGenero" runat="server"></asp:TextBox>
    </p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" CellPadding="3" ForeColor="Black" GridLines="Vertical" Height="210px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged1" Width="1059px">
        <AlternatingRowStyle BackColor="#CCCCCC" />
        <Columns>
            <asp:BoundField DataField="CdFilme" HeaderText="codigo" Visible="False" />
            <asp:BoundField DataField="CdBarras " HeaderText="CdBarras " Visible="False" />
            <asp:BoundField DataField="DsTitulo" HeaderText="Nome do filme" InsertVisible="False" ReadOnly="True" />
            <asp:BoundField DataField="NrPreco " HeaderText="NrPreco " Visible="False" />
            <asp:BoundField DataField="DtAdquirida " HeaderText="DtAdquirida " Visible="False" />
            <asp:BoundField DataField="NrValorCusto " HeaderText="NrValorCusto " Visible="False" />
            <asp:BoundField DataField="DsSituacao " HeaderText="DsSituacao " Visible="False" />
            <asp:BoundField DataField="DsAtores" HeaderText="Atore(s)" />
            <asp:BoundField DataField="DsDiretor " HeaderText="DsDiretor " Visible="False" />
            <asp:BoundField DataField="DsFotoCapa " HeaderText="DsFotoCapa " Visible="False" />
        </Columns>
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>

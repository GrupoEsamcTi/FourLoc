<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Pesquisa_filmes.aspx.cs" Inherits="WEBUI.Pesquisa_filmes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
        Nome do Filme::&nbsp;
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
&nbsp; Atores::&nbsp;
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
&nbsp;&nbsp; Gêneros&nbsp;
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
    </p>
    <p style="margin-left: 240px">
        <asp:Button ID="Button1" runat="server" Text="Pesquisar!" />
    </p>
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Height="73px" Width="650px">
        <Columns>
            <asp:BoundField DataField="DsTitulo" HeaderText="Titulo do Filme" />
            <asp:BoundField DataField="DsAno" HeaderText="Data de lançamento" />
            <asp:ImageField HeaderText="Capa do filme">
            </asp:ImageField>
        </Columns>
    </asp:GridView>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

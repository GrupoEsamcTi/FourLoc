<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WEBUI.Default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2 style="height: 216px">Página Inicial<asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" Width="638px">
        <Columns>
            <asp:HyperLinkField HeaderText="titulo" />
            <asp:ImageField HeaderText="Capa">
            </asp:ImageField>
            <asp:BoundField HeaderText="data lancamento" />
        </Columns>
        </asp:GridView>
    </h2>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Algo.Master" AutoEventWireup="true" CodeBehind="Liberar.aspx.cs" Inherits="WebApplication2.Liberar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/imagen/fondo2.png" Height="821px">
        <asp:Button ID="btnAtras" runat="server" OnClick="btnAtras_Click" Text="Atras" />
        <asp:GridView  ID="ddlmesas" runat="server" BackColor="#FFFF99" BorderColor="#FF6600" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" OnRowCreated="ddlmesas_RowCreated">
        </asp:GridView>
    <FONT 'impact' SIZE=10 COLOR="white" >  <asp:Label ID="Label1" runat="server" Text="Seleccione una mesa"></asp:Label></font>
        <asp:Button  CssClass="btn btn-primary" ID="btnLiberar" runat="server" Text="Liberar" OnClick="btnLiberar_Click" />
   </asp:Panel>
</asp:Content>

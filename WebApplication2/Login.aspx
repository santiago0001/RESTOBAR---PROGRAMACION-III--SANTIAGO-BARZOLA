<%@ Page Title="" Language="C#" MasterPageFile="~/Algo.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align ="center">
       <br />
       <br />
       <br />
       <br />
    <asp:Panel  Width="400px" ID="Panel2" runat="server" Height="183px" BackColor="#CCFFFF">
        <br />
        Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtus" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        Contraseña
        <asp:TextBox ID="txtcon" runat="server" TextMode="Password"></asp:TextBox>
        <br />
 <FONT 'impact' SIZE=3 COLOR="red" >   <asp:Label ID="lbErro" runat="server" Text="   "></asp:Label> </font>
        <br />
        <asp:Button CssClass= "btn btn-outline-primary" ID="btnIngresar" runat="server" Text="Ingresar " OnClick="Button5_Click" />
    </asp:Panel></div>
    <p>
    </p>
</asp:Content>

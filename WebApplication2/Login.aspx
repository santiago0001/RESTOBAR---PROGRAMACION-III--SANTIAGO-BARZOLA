<%@ Page Title="" Language="C#"  AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication2.Login" %>

--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">

<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Resto Barzola</title>
</head>
<body  background="https://images4.alphacoders.com/646/646937.jpg">
    <div align ="center">
       <br />
       <br />
       <br />
       <br />
    <asp:Panel  Width="400px" ID="Panel2" runat="server" Height="183px" BackColor="#CCFFFF">
        <br />
        <form id="Form1" runat="server">
        Usuario&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="txtus" runat="server"></asp:TextBox>
        &nbsp;<br />
        <br />
        Contraseña
        <asp:TextBox ID="txtcon" runat="server" TextMode="Password"></asp:TextBox>
        <br />
 <FONT 'impact' SIZE=3 COLOR="red" >   <asp:Label ID="lbErro" runat="server" Text="   "></asp:Label> </font>
        <br />
        <asp:Button CssClass= "btn btn-outline-primary" ID="btnIngresar" runat="server" Text="Ingresar " OnClick="Button5_Click" />
   </form> </asp:Panel></div>
    <p>
    </p>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
          </body>
</html>


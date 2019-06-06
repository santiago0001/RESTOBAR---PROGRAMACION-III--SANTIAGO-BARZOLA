<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Resto Barzola</title>
</head>
<body>
    <form id="form1" runat="server">
          <h1>Bienvenido <asp:Label ID="LabNombre" runat="server" Text=" "></asp:Label></h1>

        <div>
        </div>
          <asp:Button ID="ButPedido" runat="server" Text="Cargar pedido" OnClick="ButPedido_Click" /> <br /><br />
          <asp:Button ID="ButMesas" runat="server" OnClick="Button1_Click" Text="Mesas" /><br /><br />
          <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click1" /><br /><br />
          <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged" style="height: 22px" ViewStateMode="Enabled">
          </asp:DropDownList>
    </form>
</body>
</html>

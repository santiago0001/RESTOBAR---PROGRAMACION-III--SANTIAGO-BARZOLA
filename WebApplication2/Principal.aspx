<%@ Page  Language="C#" MasterPageFile="~/algo.master" AutoEventWireup="true" CodeBehind="Principal.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Resto Barzola</title>
</head>
<body>--%>

<asp:Content  ID="idContent" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">
        
        <div>
        </div>

        <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/imagen/fondo2.png" Height="381px">
           <br/>
              <div align= "center"> 
            <FONT 'impact' SIZE=30 COLOR="White" >Bienvenido <asp:Label ID="LabNombre" runat="server" Text=" " COLOR="White"></asp:Label></FONT > <br/><br/>

            <asp:Button CssClass="btn btn-primary"  ID="ButPedido" runat="server" Text="Cargar pedido" OnClick="ButPedido_Click1"  /> <br/>
                  <br />
                  <asp:Button  CssClass="btn btn-primary" ID="btnLiberar" runat="server" Text="Liberar mesa" OnClick="btnLiberar_Click" />
                  <br />
                  <br />
                  <asp:Button  CssClass="btn btn-primary" ID="btnOcupar" runat="server" Text="Ocupar mesa" />
                  <br />
                  <br/>
                  <asp:Button  CssClass="btn btn-primary" ID="btnPedPen" runat="server" Text="Pedidos pendientes" />
                   <br />
                  <br/>
                  <asp:Button  CssClass="btn btn-primary" ID="btnCobrar" runat="server" Text="Cobrar" />
                  <br />
                  <br/>
    <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="DropDownList1_TextChanged" ViewStateMode="Enabled" Height="28px">
          </asp:DropDownList>
        </div>
        </asp:Panel>
    <br /><br />
        <%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Resto Barzola</title>
</head>
<body>--%>
          

</asp:Content>

<%--</body>
</html>--%>

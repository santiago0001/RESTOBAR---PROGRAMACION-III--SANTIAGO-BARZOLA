<%@ Page Language="C#"  MasterPageFile="~/algo.master" AutoEventWireup="true" CodeBehind="mesapagg.aspx.cs" Inherits="WebApplication2.mesapagg" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>--%>
    <asp:Content  ID="idContentMesa" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

        <div>

         <div align="center">
             <asp:Button ID="butAtras" runat="server" OnClick="butAtras_Click" Text="Atras" />
            <FONT 'impact' SIZE=20 COLOR="blue" >
             <br />
 Seleccione la mesa</FONT>
            .<HR noshade size="5" width=90%>
             
         
           <asp:DropDownList ID="ddlMesa" runat="server" Height="46px" Width="242px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
         </asp:DropDownList>
             <br />
             <br />
             <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Siguiente" />
            </div>

       

         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

       

    
        </div>
    
        </asp:Content>

<%--</body>
</html>--%>

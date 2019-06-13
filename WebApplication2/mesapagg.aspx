<%@ Page Language="C#"  MasterPageFile="~/algo.master" AutoEventWireup="true" CodeBehind="mesapagg.aspx.cs" Inherits="WebApplication2.mesapagg" %>

<%--<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>--%>
    <asp:Content  ID="idContentMesa" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">


         
           
            

       


       

    
            <asp:Panel ID="Panel1" runat="server" Height="539px" BackImageUrl="~/imagen/fondo2.png">

                <asp:Button ID="butAtras" runat="server" OnClick="butAtras_Click" Text="Atras" />

                <div align="center">
                 <FONT 'impact' SIZE=20 COLOR="white" >
             <br />
 Seleccione la mesa</FONT> <br /> <br />
                <asp:DropDownList ID="ddlMesa" runat="server" AutoPostBack="True" Height="46px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="242px">
                </asp:DropDownList>
                    .<hr noshade size="30" width="90%"> </hr>
                        <br />
                        <br />                   

                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Siguiente" />
                             <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
                                </div>

            </asp:Panel>

       

    
    
        </asp:Content>

<%--</body>
</html>--%>

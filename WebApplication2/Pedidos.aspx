<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 194px;
        }
        .auto-style2 {
            width: 209px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <FONT 'impact' SIZE=30 COLOR="blue" >
 Carga de pedidos</FONT>
            .<HR noshade size="5" width=90%>
             </div>
        <table class="egt">

  <tr align="center">

    <td class="auto-style1"> Tipo de plato</td>

    <td class="auto-style2"> Plato</td>

    <td>Cantidad</td>

  </tr>

  <tr align="center">
     
    <td class="auto-style1"><asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="172px">
        </asp:DropDownList></td> 

    <td class="auto-style2"><asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="172px">
        </asp:DropDownList></td>

    <td  ><asp:TextBox ID="TextBox3" runat="server" Width="155px"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Cargar pedido" />
        </td>

  </tr>

</table>    



     
        <br />
        <br />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
             </form>
            
        <br />


   
</body>
</html>

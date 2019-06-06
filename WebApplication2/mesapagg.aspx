<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="mesapagg.aspx.cs" Inherits="WebApplication2.mesapagg" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    
        <div><form id="form2" runat="server">

         <div align="center">
            <FONT 'impact' SIZE=20 COLOR="blue" >
 Seleccione la mesa</FONT>
            .<HR noshade size="5" width=90%>
             
         
           <asp:DropDownList ID="ddlMesa" runat="server" Height="46px" Width="242px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
         </asp:DropDownList></div>

       

         <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

       

    
        </div>
    </form>
</body>
</html>

<%@ Page Title="" Language="C#" MasterPageFile="~/Algo.Master" AutoEventWireup="true" CodeBehind="Cobrar.aspx.cs" Inherits="WebApplication2.Cobrar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/imagen/fondo2.png" Height="821px">

    <br /><div align ="center"> 
&nbsp; <FONT 'impact' SIZE=10 COLOR="White" > 
    Mesa
    <asp:DropDownList ID="ddlmesa" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
    </asp:DropDownList>

    <br />
                <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />
&nbsp;&nbsp;</font> <br/> <br/><br/>


        
<table class="egt"align="center" >
        <tr align="left">
                               <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Platos</b></FONT ></td>
            
<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
            <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Bebidas</b></FONT ></td>
                                   </tr><tr align="left"><td>
              <asp:GridView ID="GVplatos" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCreated="GVplatos_RowCreated" OnSelectedIndexChanged="GVplatos_SelectedIndexChanged">
              <AlternatingRowStyle BackColor="#DCDCDC" />
                <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
               <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
               <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
                <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
               <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#0000A9" />
               <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#000065" />
                 </asp:GridView>   
                               </td>
<td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</td>
                <td>
                     <asp:GridView ID="GVbebidas" runat="server" BackColor="White" BorderColor="#999999" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Vertical" OnRowCreated="GVbebidas_RowCreated" OnSelectedIndexChanged="GVbebidas_SelectedIndexChanged">
        <AlternatingRowStyle BackColor="#DCDCDC" />
        <FooterStyle BackColor="#CCCCCC" ForeColor="Black" />
        <HeaderStyle BackColor="#000084" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <RowStyle BackColor="#EEEEEE" ForeColor="Black" />
        <SelectedRowStyle BackColor="#008A8C" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#0000A9" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#000065" />
    </asp:GridView>

                </td> </tr>

     <tr > 
          <td align="right">   <asp:Button CssClass="btn btn-primary" ID="Button5" runat="server" Text="Cobrar" Height="49px" Width="102px" OnClick="Button5_Click" /> </td>
         <td align="left"> 
         <FONT 'impact' SIZE=6 COLOR="White" >    <asp:Label ID="LabTotal" runat="server" Text="TOTAL"></asp:Label>
          </td></font>
     </tr>
                                                    
   </table>
    

    



             
    <p>
    </p> </asp:Panel>
</asp:Content>

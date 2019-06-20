<%@ Page Title="" Language="C#" MasterPageFile="~/Algo.Master" AutoEventWireup="true" CodeBehind="Pendientes.aspx.cs" Inherits="WebApplication2.WebForm3" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


            <asp:Panel ID="Panel1" runat="server" BackImageUrl="~/imagen/fondo2.png" Height="821px">
<%--                       <asp:Button ID="btnAtras" runat="server" OnClick="btnAtras_Click" Text="Atras" />--%>




                        &nbsp;
                        <br />
        <div align ="center"> <FONT 'impact' SIZE=6 COLOR="White" >
            <asp:Label ID="labMesa" runat="server" Text="Mesa "></asp:Label>
            
            </div>
                        <br />
                Numero de mesa</FONT>&nbsp;&nbsp;<asp:DropDownList ID="ddlMesas" runat="server" AutoPostBack="True">
                </asp:DropDownList>
                <b>
                <br />
                </b>
                        <br />
                            

                            <table class="egt"align="left" >
                         
                         
                           <tr align="left">
                               <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Platos pendientes</b></FONT > <b>
                                   <asp:GridView ID="gbPlatos" runat="server" BackColor="#DEBA84" OnSelectedIndexChanged="gdvPedido_SelectedIndexChanged" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCreated="gbPlatos_RowCreated" OnRowDataBound="gbPlatos_RowDataBound">
                                       <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                       <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                       <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                       <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                       <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                       <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                       <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                       <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                       <SortedDescendingHeaderStyle BackColor="#93451F" />
                                   </asp:GridView>
                                <FONT 'impact' SIZE=3 COLOR="White" >   <asp:Label ID="labPedpla" runat="server" Text="Seleccione un plato"></asp:Label> </font>
                                   </b>
                                   <asp:Button ID="Button5" runat="server" Text="Entregado" CssClass="btn btn-primary" OnClick="Button5_Click" />
                               </td>
                               
                           </tr>
                                                    
                           </table>


                <table class="egt"align="right" >
                         
                         
                           <tr align="left">
                               <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Bebidas pendientes</b></FONT > <b>
                                   <asp:GridView ID="gvBebidas" runat="server" BackColor="#DEBA84" OnSelectedIndexChanged="gdvPedidoBebida_SelectedIndexChanged" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowCreated="gvBebidas_RowCreated">
                                       <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                                       <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                                       <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                                       <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                                       <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                                       <SortedAscendingCellStyle BackColor="#FFF1D4" />
                                       <SortedAscendingHeaderStyle BackColor="#B95C30" />
                                       <SortedDescendingCellStyle BackColor="#F1E5CE" />
                                       <SortedDescendingHeaderStyle BackColor="#93451F" />
                                   </asp:GridView>
                                   
                                   </b>
                              <FONT 'impact' SIZE=3 COLOR="White" >     <asp:Label ID="labBeb" runat="server" Text="Seleccione una bebida"></asp:Label>  </font>
                                   <asp:Button ID="Button6" runat="server" Text="Entregado" CssClass="btn btn-primary" OnClick="Button6_Click" />
                               </td>
                               
                           </tr>
                                                    
                           </table>


    </asp:Panel>

</asp:Content>

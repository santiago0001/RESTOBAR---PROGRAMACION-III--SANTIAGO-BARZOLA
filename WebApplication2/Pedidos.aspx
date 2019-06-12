<%@ Page Language="C#"  MasterPageFile="~/algo.master" AutoEventWireup="true" CodeBehind="Pedidos.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<%--<!DOCTYPE html>

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
    <form id="form1" runat="server">--%>
    <asp:Content  ID="idContentPedido" runat="server" ContentPlaceHolderID="ContentPlaceHolder1">

<%--<!DOCTYPE html>

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
    <form id="form1" runat="server">--%>
                

            <asp:Panel ID="Panel3" runat="server" BackImageUrl="~/imagen/fondo2.png" CssClass="auto-style4" Height="1040px">
               
                            <asp:Button ID="butAtras" class="btn btn-light" runat="server" OnClick="butAtras_Click" Text="Atras" />

                 <br />                  
                <b><font "impact" color="blue" size="30">
                    <asp:Label ID="Label3" runat="server" Text="Carga de pedidos" top="2" BackColor="#99CCFF"></asp:Label>
                </font></b>                

               <b><font "impact" color="blue" size="30">
                    <asp:Label ID="Label1" runat="server" Text="Mesa" BackColor="#99CCFF"></asp:Label>                                           <asp:Label  ID="LabelMesero" BackColor="#99CCFF" runat="server" Text=" "></asp:Label>
      <asp:Label ID="LabelNom" runat="server" Text=" "></asp:Label>

                &nbsp;

                </font></b>
                 <br />

                <br /><br />
                <table class="egt" align="left">
                    <tr align="center">
                        <td class="auto-style1" ><FONT 'impact' SIZE=3 COLOR="White" ><b>Tipo de plato</b></FONT ></td>
                    </tr> 
                    <tr align="center">
                        <td class="auto-style1">
                            <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddltipo" runat="server" Height="35px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="ddltipo_TextChanged">
                            </asp:DropDownList>
                        </td>
                       
                    </tr> <tr><td><FONT 'impact' SIZE=3 COLOR="White" ><b>Plato</b></FONT > </tr>
                    <tr><td class="auto-style2"><asp:DropDownList ID="ddlPlato" runat="server" class="btn btn-secondary dropdown-toggle" Height="35px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="172px">
                            </asp:DropDownList></td></tr>

                     </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b>Cantidad</b></FONT ></td></tr>
                    </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b><asp:TextBox ID="txtCant" runat="server" Width="155px"></asp:TextBox></b></FONT ></td></tr>
              </tr> <tr><td class="auto-style2"><asp:Button ID="butCarga" runat="server" class="btn btn-primary btn-lg"  OnClick="butCarga_Click" Text="Cargar plato" /></b></FONT ></td></tr>
                </table>



                               <table class="egt" align="right">
                    <tr align="center">
                        <td class="auto-style1" ><FONT 'impact' SIZE=3 COLOR="White" ><b>Marca de bebida</b></FONT ></td>
                    </tr> 
                    <tr align="center">
                        <td class="auto-style1">
                            <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddlMarcas" runat="server" Height="35px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="ddltipo_TextChanged">
                            </asp:DropDownList>
                        </td>
                       
                    </tr> <tr><td><FONT 'impact' SIZE=3 COLOR="White" ><b>Bebida</b></FONT > </tr>
                    <tr><td class="auto-style2"><asp:DropDownList ID="ddlbebida" runat="server" class="btn btn-secondary dropdown-toggle" Height="35px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="172px">
                            </asp:DropDownList></td></tr>

                     </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b>Cantidad</b></FONT ></td></tr>
                    </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b><asp:TextBox ID="TextBox1" runat="server" Width="155px"></asp:TextBox></b></FONT ></td></tr>
              </tr> <tr><td class="auto-style2"><asp:Button ID="Button1" runat="server" class="btn btn-primary btn-lg"  OnClick="butCarga_Click" Text="Cargar bebida" /></b></FONT ></td></tr>
                </table>

                <br />
                <b>
                
                </b>
                <br /><br /><br /><br /><br /><br /><br />
                <br />
                <br />


                <b>

                     <table class="egt"align="left" >
                         
                         
                           <tr align="left">
                               <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Platos pedidos</b></FONT > <b>
                                   <asp:GridView ID="gdvPedido" runat="server" BackColor="#FFFFCC" OnSelectedIndexChanged="gdvPedido_SelectedIndexChanged">
                                   </asp:GridView>
                                   </b>
                               </td>
                               
                           </tr>
                                                    
                           </table>


                    <table class="egt"align="right" >
                         
                         
                           <tr align="left">
                               <td><FONT 'impact' SIZE=6 COLOR="White" ><b>Bebidas pedido</b></FONT > <b>
                                   <asp:GridView ID="gvBebidas" runat="server" BackColor="#FFFFCC" OnSelectedIndexChanged="gdvPedido_SelectedIndexChanged">
                                   </asp:GridView>
                                   </b>
                               </td>
                               
                           </tr>
                                                    
                           </table>
                </b>
            </asp:Panel>
            <br />
            </b>
             
        <center>



     
        <br />
        <br />
        </center>        

        <br />
        
                </asp:Content>

            <%-- </form>
            
        <br />


   
</body>
</html>--%>
<asp:Content ID="Content1" runat="server" contentplaceholderid="head">
    <style type="text/css">
        .auto-style2 {
            height: -15px;
        }
        .auto-style4 {
            margin-top: 14px;
        }
        </style>
</asp:Content>


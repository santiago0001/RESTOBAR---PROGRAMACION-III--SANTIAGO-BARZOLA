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
               
                 <br />                  
             <font "impact" color="white" size="5">   Seleccione una mesa</font> <asp:DropDownList ID="ddlMesa" runat="server" AutoPostBack="True" Height="29px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" Width="61px">
                </asp:DropDownList> <br/>
                <b><font "impact" color="white" size="30">
                    <asp:Label ID="Label3" runat="server" Text="Carga de pedidos" top="2" ></asp:Label>
                </font></b>                

               <b><font "impact" color="white" size="30">
                    <asp:Label ID="Label1" runat="server" Text="Mesa" ></asp:Label>                                           <asp:Label  ID="LabelMesero"  runat="server" Text=" "></asp:Label>
      <asp:Label ID="LabelNom" runat="server" Text=" "></asp:Label>

                &nbsp;

                </font> </b>
                 <br />

                <br /><br />
                <table class="egt" align="left">
                    <tr align="left">
                        <td class="auto-style1" ><FONT 'impact' SIZE=3 COLOR="White" ><b>Tipo de plato</b></FONT ></td>
                    </tr> 
                    <tr align="left">
                        <td class="auto-style1">
                            <asp:DropDownList class="btn btn-secondary dropdown-toggle" ID="ddltipo" runat="server" Height="35px" Width="172px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" OnTextChanged="ddltipo_TextChanged">
                            </asp:DropDownList>
                        </td>
                       
                    </tr> <tr><td><FONT 'impact' SIZE=3 COLOR="White" ><b>Plato</b></FONT > </tr>
                    <tr><td class="auto-style2"><asp:DropDownList ID="ddlPlato" runat="server" class="btn btn-secondary dropdown-toggle" Height="32px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="324px" OnTextChanged="ddlPlato_TextChanged" AutoPostBack="True">
                            </asp:DropDownList> <FONT 'impact' SIZE=6 COLOR="White" ><b>  &nbsp;&nbsp;&nbsp; $ <asp:Label ID="labPrecio" runat="server" Text="Label" color="white"></b></asp:Label></FONT > </td></tr>

                     </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b>Cantidad<font "impact" color="Red" size="5">
                        <br />
                        <asp:Label ID="LabErrorPla" runat="server" Text="*"></asp:Label>
                        </font></b></FONT ></td></tr>
                    </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b>

                        <asp:TextBox ID="txtCant" runat="server" Width="155px"></asp:TextBox>

                                                                                           </b>
                        </FONT ></td></tr>
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
                       
                    </tr> <tr><td class="auto-style5"><FONT 'impact' SIZE=3 COLOR="White" ><b>Bebida</b></FONT > </tr>
                    <tr><td class="auto-style2"><asp:DropDownList ID="ddlbebida" runat="server" class="btn btn-secondary dropdown-toggle" Height="35px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" Width="172px" AutoPostBack="True" OnTextChanged="ddlbebida_TextChanged">
                            </asp:DropDownList><br/><FONT 'impact' SIZE=3 COLOR="White" ><b> <asp:Label ID="DescBeb" runat="server" Text="Label"></asp:Label> </b></FONT></td></tr>

                     </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b>Cantidad<font "impact" color="Red" size="5">
                                     <br/>  <asp:Label ID="LabErrorBe" runat="server" Text="*"></asp:Label>
                                       </font></b></FONT ></td></tr>
                    </tr> <tr><td class="auto-style2"><FONT 'impact' SIZE=3 COLOR="White" ><b><asp:TextBox ID="txtcantbeb" runat="server" Width="155px" OnTextChanged="txtcantbeb_TextChanged"></asp:TextBox></b>
                                       </FONT ></td></tr>
              </tr> <tr><td class="auto-style2"><asp:Button ID="btncargaBeb" runat="server" class="btn btn-primary btn-lg"  OnClick="butCargabeb_Click" Text="Cargar bebida" /></b></FONT ></td></tr>
                </table>

                <br />
                <b>
                
                </b>
                <br /><br /><br />
                         
                            <br /><br /><br />
                            
                            <br />
                <br />
                <br />
                <br /><br /><br />

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
        .auto-style5 {
            height: 26px;
        }
        </style>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="Menu.aspx.cs" Inherits="Distribuidora.Menu" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
          <div class="tm-flex">
    <div class="tm-sidebar sticky">
                        <ul class="tm-main-nav-ul">
                            <li class="tm-nav-item">                              
                                <asp:Button ID="BtnEmpleado" runat="server" type="submit"  class="tm-nav-item-link tm-button"
                                    Text="Alta Empleado" OnClick="BtnEmpleado_Click"/>
                            </li>
                            <li class="tm-nav-item"> 
                                <asp:Button ID="BtnProducto" runat="server" type="submit"  class="tm-nav-item-link tm-button"
                                    Text="Alta producto" OnClick="BtnProducto_Click"/>
                            </li>
                            <li class="tm-nav-item">
                                <asp:Button ID="BtnAsignacion" runat="server" type="submit"  class="tm-nav-item-link tm-button"
                                    Text="Asignacion tecnico" OnClick="BtnAsignacion_Click"/>
                            </li>
                            <li class="tm-nav-item">
                                <asp:Button ID="BtnListado" runat="server" type="submit"  class="tm-nav-item-link tm-button"
                                    Text="Listado productos fabricados" OnClick="BtnListado_Click"/>
                            </li>
                        </ul>
                </div> 
                </div> 
</asp:Content>

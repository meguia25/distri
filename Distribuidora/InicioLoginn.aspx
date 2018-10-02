<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="InicioLoginn.aspx.cs" Inherits="Distribuidora.InicioLoginn" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <asp:Login ID="Login1" OnAuthenticate="Login1_Authenticate" runat="server"></asp:Login>
    </div>
    <div class="form-group">
        <asp:Button ID="BtnListadoTipo" runat="server" type="submit" class="tm-nav-item-link tm-button"
            Text="Listado por tipo de producto" OnClick="BtnListadoTipo_Click" />
    </div>
</asp:Content>

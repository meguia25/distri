<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AsignacionEmpProdd.aspx.cs" Inherits="Distribuidora.AsignacionEmpProdd" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-group">
        <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
    </div>
    <div class="form-group">
        <asp:DropDownList ID="DDLProductos" runat="server" OnSelectedIndexChanged="DDLProductos_SelectedIndexChanged"></asp:DropDownList>
        <asp:DropDownList ID="DDLTecnicos" runat="server" OnSelectedIndexChanged="DDLTecnicos_SelectedIndexChanged"></asp:DropDownList>
    </div>
    <div class="form-group">
        <asp:TextBox ID="TxtDescripcion" Text="Descripción" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:TextBox ID="TxtTiempo1" Text="Tiempo" runat="server"></asp:TextBox>
    </div>
    <div class="form-group">
        <asp:Button ID="BtnAlta" runat="server" type="submit"
            class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Guardar" OnClick="BtnAlta_Click" />
    </div>
    <div class="form-group">
        <asp:Label ID="LblMensaje" runat="server" Text="" />
    </div>
</asp:Content>

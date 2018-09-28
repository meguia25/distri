<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaEmpleadoo.aspx.cs" Inherits="Distribuidora.AltaEmpleadoo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-flex">
        <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
            </div>
            <h2 class="tm-section-title">Alta Empleado</h2>
            <div class="form-group">
                <asp:TextBox class="form-control" ID="TxtNombre" runat="server" Text="Nombre" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox class="form-control" runat="server" ID="TxtEmail" Text="Email" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtEmail" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox class="form-control" runat="server" ID="TxtContrasenia" Text="Contrasenia" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtContrasenia" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:Button ID="BtnAlta" runat="server" type="submit"
                    class="btn btn-primary pull-xs-right tm-button tm-button-normal" Text="Guardar" OnClick="BtnAlta_Click" />
            </div>
            <div class="form-group">
                <asp:Label ID="LblMensaje" runat="server" Text="" />
            </div>
        </div>
    </div>
</asp:Content>

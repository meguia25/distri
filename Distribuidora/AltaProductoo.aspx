<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AltaProductoo.aspx.cs" Inherits="Distribuidora.AltaProductoo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="tm-flex">
        <div class="tm-contact-left-half tm-gray-bg">
            <div class="form-group">
                <asp:LinkButton ID="BtnVolver" runat="server" OnClick="BtnVolver_Click">Volver al menú</asp:LinkButton>
            </div>
            <h2 class="tm-section-title">Alta Producto</h2>
            <div class="form-group">
                <asp:TextBox ID="TxtCodigo" runat="server" Text="Codigo" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="TxtCodigo" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox ID="TxtNombre" runat="server" Text="Nombre" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TxtNombre" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtDescripcion" Text="Descripción" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtDescripcion" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtCosto" Text="Costo" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtCosto" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtPrecioSugerido" Text="Precio de venta sugerido" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TxtPrecioSugerido" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:RadioButton ID="RdbFabricado" runat="server" GroupName="TipoProducto" Text="Fabricado"/>
                <asp:RadioButton ID="RdbImportado" runat="server" GroupName="TipoProducto" Text="Importado"/>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtTiempo" Text="Tiempo" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="TxtTiempo" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtPaisOrigen" Text="Pais Origen" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="TxtPaisOrigen" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
            </div>
            <div class="form-group">
                <asp:TextBox runat="server" ID="TxtCantMinima" Text="Cantidad minima" />
                <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="TxtCantMinima" ErrorMessage="Campo obligatorio">*</asp:RequiredFieldValidator>
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

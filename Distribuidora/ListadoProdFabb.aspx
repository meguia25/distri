<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="ListadoProdFabb.aspx.cs" Inherits="Distribuidora.ListadoProdFabb" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:GridView ID="GridView1" OnRowCommand="GridView1_RowCommand" DataKeyNames="codigo" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField AccessibleHeaderText="Código de Producto" DataField="Codigo" HeaderText="Código Producto" />
                <asp:BoundField AccessibleHeaderText="Nombre" DataField="nombre" HeaderText="Nombre" />
                <asp:BoundField AccessibleHeaderText="Descripción" DataField="descripcion" HeaderText="Descripción" />
                <asp:BoundField AccessibleHeaderText="Tiempo de Fabricación" DataField="Tiempo" HeaderText="Tiempo de Fabricación" />
                <asp:BoundField AccessibleHeaderText="Costo" DataField="costo" HeaderText="Costo" />
            </Columns>
        </asp:GridView>
</asp:Content>

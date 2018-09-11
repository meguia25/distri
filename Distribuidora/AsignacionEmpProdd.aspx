<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="AsignacionEmpProdd.aspx.cs" Inherits="Distribuidora.AsignacionEmpProdd" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
            <asp:GridView ID="GridView1" OnRowCommand="GridView1_RowCommand" DataKeyNames="Codigo" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField AccessibleHeaderText="Codigo" DataField="codigo" HeaderText="Codigo" />
                <asp:BoundField AccessibleHeaderText="Nombre" DataField="nombre" HeaderText="Nombre" />
                <asp:ButtonField AccessibleHeaderText="Asignar Tecnico" ButtonType="Button" CommandName="asignar" Text="Asignar Tecnico &gt;" />
            </Columns>
        </asp:GridView>
</asp:Content>

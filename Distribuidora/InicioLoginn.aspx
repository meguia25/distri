<%@ Page Title="" Language="C#" MasterPageFile="~/Maestra.Master" AutoEventWireup="true" CodeBehind="InicioLoginn.aspx.cs" Inherits="Distribuidora.InicioLoginn" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Login ID="Login1" OnAuthenticate="Login1_Authenticate" runat="server"></asp:Login>
    </div>
</asp:Content>

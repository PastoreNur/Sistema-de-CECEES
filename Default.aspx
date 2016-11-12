<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>¡Bienvenido!</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CerrarSesion" Runat="Server">
    
    <asp:Button ID="Sesion" runat="server" Text="Iniciar Sesión" CssClass="btn btn-defaul btn-lg" OnClick="Sesion_Click"/>
    

</asp:Content>


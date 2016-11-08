<%@ Page Title="" Language="C#" MasterPageFile="Login.master" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

        <h2>Formulario de Login</h2>
        <asp:TextBox ID="TextBox1" runat="server" CssClass="txtUsuario" placeholder="Usuario"></asp:TextBox>
        <asp:TextBox ID="TextBox2" runat="server" CssClass="txtContraseña" placeholder="Contraseña" type="password"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" Text="Iniciar" class="iniciar"/>

</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Matricula.aspx.cs" Inherits="Matricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<h3>Apellidos del alumno:</h3>
        <asp:TextBox ID="TxtApellidosAlum" CssClass="form-control" placeholder="Apellidos" runat="server"></asp:TextBox>
    <br />
    <h3>Nombres del alumno:</h3>
    <asp:TextBox ID="TxtNombresAlum" CssClass="form-control" placeholder="Nombres" runat="server"></asp:TextBox>
    <br />
    <h3>Genero:</h3>
    <asp:DropDownList ID="DdlGenero" CssClass="form-control" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Masculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
    </asp:DropDownList>
    <br />
    <h3>Fecha de nacimiento: </h3>
    <asp:TextBox ID="TxtNacimento" cssclase="form-control" placeholder="Dia/Mes/Año" runat="server"></asp:TextBox>
    <br />
    <h3>Edad: </h3>
    <asp:TextBox ID="TxtEdad" CssClass="form-control" placeholder="Edad" runat="server"></asp:TextBox>
    <br />
    <h3>Lugar de nacimiento: </h3>
    <asp:TextBox ID="TxtLugardenac" cssclass="form-control" placeholder="Lugar de nacimiento" runat="server"></asp:TextBox>
    <br />
    <h3>Zona de residencia:</h3>
    <asp:DropDownList ID="DdlZona" CssClass="form-control" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Urbano</asp:ListItem>
        <asp:ListItem>Rural</asp:ListItem>
    </asp:DropDownList>
    <br />
    <h3>Nacionalidad:</h3>
    <asp:TextBox ID="TxtNacionalidad" cssclass="form-control" placeholder="Nacionalidad" runat="server"></asp:TextBox>
    <br />
    <h3>Telefono de casa: </h3>
    <asp:TextBox ID="TxtTelCasa" cssclass="form-control" placeholder="Telefono de casa" runat="server"></asp:TextBox>
    <br />
    <h3>Celular:</h3>
    <asp:TextBox ID="TxtCel" CssClass="form-control" placeholder="Celular" runat="server"></asp:TextBox>
</asp:Content>


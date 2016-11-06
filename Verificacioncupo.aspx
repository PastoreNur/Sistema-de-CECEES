<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Verificacioncupo.aspx.cs" Inherits="Verificacioncupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>Seleccione una sección:</p>
    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:Button ID="BtnCancelarCupo" runat="server" Text="Cancelar" />
    <asp:Button ID="BtnSigCupo" runat="server" Text="Siguiente" />
</asp:Content>


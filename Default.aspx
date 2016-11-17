<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>¡Bienvenido!</h1>
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="CerrarSesion" Runat="Server">
    
    <asp:Button ID="Sesion" runat="server" Text="Iniciar Sesión" CssClass="btn navbar-btn" OnClick="Sesion_Click" />
    

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="NomUsuario" Runat="Server">
 

                     
                      <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                        <asp:Label ID="LblNomUser" runat="server" Text="Invitado"></asp:Label>
                          <span class="caret"></span></a>
                      


</asp:Content>

    <asp:Content ID="Content5" ContentPlaceHolderID="Panel" Runat="Server">
        <asp:Button ID="PanelAdministracion" runat="server" Text="Administración" CssClass="btn btn-link" OnClick="PanelAdministracion_Click" />    
        <li role="separator" class="divider"></li>
        
    </asp:Content>

<asp:Content ID="Content6" ContentPlaceHolderID="btncerrar" runat="server">
    <asp:Button ID="BtnCerrarSesion" runat="server" Text="Cerrar Sesión" CssClass="btn btn-link" OnClick="BtnCerrarSesion_Click" />
</asp:Content>




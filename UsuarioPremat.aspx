<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="UsuarioPremat.aspx.cs" Inherits="UsuarioPremat" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="NomUsuario" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="Panel" Runat="Server">
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="btncerrar" Runat="Server">
</asp:Content>
<asp:Content ID="Content5" ContentPlaceHolderID="CerrarSesion" Runat="Server">
</asp:Content>
<asp:Content ID="Content6" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

  
        
    <div class="row">

        <div class="col-md-2"></div>

    
   <div class="col-md-8">
       <div class="panel panel-primary">
           <div class="panel-heading"><h3 class="panel-title"><asp:Label ID="Label12" runat="server" Text="Registrar Usuario" ></asp:Label></h3>
           </div>
           <div class="panel-body">
               <div class="form-group">
       <asp:Label ID="Label6" runat="server" Text="Numero de celular:" ></asp:Label>
    <asp:TextBox ID="txtCodUser" runat="server" class="form-control"></asp:TextBox>
    
    </div>
           <div class="form-group">
       <asp:Label ID="Label10" runat="server" Text="Nombre de Usuario" visible="false"></asp:Label>
    <asp:TextBox ID="txtNombreUsuario" runat="server" class="form-control" Enabled="false" Visible="false"></asp:TextBox>
    </div>     
     <div class="form-group">
       <asp:Label ID="Label7" runat="server" Text="Primer Nombre" ></asp:Label>
    <asp:TextBox ID="txtFirstName" runat="server" class="form-control"></asp:TextBox>
    </div>
     <div class="form-group">
       <asp:Label ID="Label8" runat="server" Text="Segundo Nombre" ></asp:Label>
    <asp:TextBox ID="txtSecondName" runat="server" class="form-control"></asp:TextBox>
    </div>
      <div class="form-group">
       <asp:Label ID="Label9" runat="server" Text="Primer Apellido" ></asp:Label>
    <asp:TextBox ID="txtFirstLastName" runat="server" class="form-control"></asp:TextBox>
    </div>
                 <div class="form-group">
       <asp:Label ID="Label1" runat="server" Text="Segundo Apellido" ></asp:Label>
    <asp:TextBox ID="txtSecondLastName" runat="server" class="form-control"></asp:TextBox>
    </div>
     <div class="form-group">
       <asp:Label ID="Label2" runat="server" Text="E-Mail" ></asp:Label>
    <asp:TextBox ID="txtEmail" runat="server" class="form-control"></asp:TextBox>
    </div>

               <div class="form-group">
       <asp:Label ID="Label11" runat="server" Text="Tipo de Usuario" Visible="false" Enabled="false"></asp:Label>
    <asp:TextBox ID="txtTipoUserbx" runat="server" class="form-control" Visible="false" Enabled="false"></asp:TextBox>
    </div>

   
      <div class="form-group">
       <asp:Label ID="Label4" runat="server" Text="Contraseña" ></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
    </div>
     
    <asp:Button ID="guardar" runat="server" Text="Registrar" class="btn btn-primary btn-block" OnClick="guardar_Click"/>
    <div class="row">
        <div class="col-md-3"></div>
      

           </div>
           </div>
       </div>

        
        
    </div>
    </div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentAside" Runat="Server">
    <div class="row">

        <div class="col-md-1"></div>
        <div class="col-md-10">

            <h4 style="text-align:justify; font-family: fantasy">La solicitud de matricula fue enviada con exito, ahora debe crear un usuario para recibir notificaciones acerca de su proceso de matricula (Este usuario se eliminara cuando comiencen clases).</h4>

        </div>
        <div class="col-md-1"></div>
    </div>
</asp:Content>

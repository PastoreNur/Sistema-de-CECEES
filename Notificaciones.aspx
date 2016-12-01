<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Notificaciones.aspx.cs" Inherits="Notificaciones" %>

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
<asp:Label ID="Label1" runat="server" Visible="false" CssClass="h4" Text="Comentario 1:"></asp:Label>  
            <br /> 
<asp:Label ID="Label2" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />    
<asp:Label ID="Label3" runat="server" Visible="false" CssClass="h4" Text="Comentario 2:"></asp:Label>
            <br /> 
<asp:Label ID="Label4" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />  
<asp:Label ID="Label5" runat="server" Visible="false" CssClass="h4" Text="Comentario 3:"></asp:Label>
            <br />
<asp:Label ID="Label6" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />  
<asp:Label ID="Label7" runat="server" Visible="false" CssClass="h4" Text="Comentario 4:"></asp:Label> 
            <br /> 
<asp:Label ID="Label8" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />  
<asp:Label ID="Label9" runat="server" Visible="false" CssClass="h4" Text="Comentario 5:"></asp:Label>
            <br />  
<asp:Label ID="Label10" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />   
<asp:Label ID="Label11" runat="server" CssClass="h4" Visible="false" Text="Comentario 6:"></asp:Label>
            <br />   
<asp:Label ID="Label12" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />   
<asp:Label ID="Label13" runat="server" Visible="false" CssClass="h4" Text="Comentario 7:"></asp:Label>
            <br />  
<asp:Label ID="Label14" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />  
<asp:Label ID="Label15" runat="server" Visible="false" CssClass="h4" Text="Comentario 8:"></asp:Label>
            <br />   
<asp:Label ID="Label16" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />   
<asp:Label ID="Label17" runat="server" Visible="false" CssClass="h4" Text="Comentario 9:"></asp:Label>
            <br />   
<asp:Label ID="Label18" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
<asp:Label ID="Label20" runat="server" Visible="false" CssClass="h4" Text="Comentario 10:"></asp:Label>
            <br />
<asp:Label ID="Label21" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
<asp:Label ID="Label22" runat="server" Visible="false" CssClass="h4" Text="Comentario 11:"></asp:Label>
            <br />
<asp:Label ID="Label19" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
<asp:Label ID="Label23" runat="server" Visible="false" CssClass="h4" Text="Comentario 12:"></asp:Label>
            <br />
<asp:Label ID="Label24" runat="server" Visible="false" Text="Label"></asp:Label>
            <br /> 
<asp:Label ID="Label25" runat="server" Visible="false" CssClass="h4" Text="Comentario 13:"></asp:Label>
            <br />
<asp:Label ID="Label26" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
<asp:Label ID="Label27" runat="server" Visible="false" CssClass="h4" Text="Comentario 14:"></asp:Label>
            <br />
<asp:Label ID="Label28" runat="server" Visible="false" Text="Label"></asp:Label>
            <br /> 
<asp:Label ID="Label29" runat="server" Visible="false" CssClass="h4" Text="Comentario 15:"></asp:Label>
            <br />  
<asp:Label ID="Label30" runat="server" Visible="false" Text="Label"></asp:Label>  
            <br />
<asp:Label ID="Label31" runat="server" Visible="false" CssClass="h4" Text="Comentario 16:"></asp:Label>   
            <br />
<asp:Label ID="Label32" runat="server" Visible="false" Text="Label"></asp:Label>  
            <br />
<asp:Label ID="Label33" runat="server" Visible="false" CssClass="h4" Text="Comentario 17:"></asp:Label>  
            <br /> 
<asp:Label ID="Label34" runat="server" Visible="false" Text="Label"></asp:Label>   
            <br />
<asp:Label ID="Label35" runat="server" Visible="false" CssClass="h4" Text="Comentario 18:"></asp:Label>    
            <br />
<asp:Label ID="Label36" runat="server" Visible="false" Text="Label"></asp:Label>   
            <br />
<asp:Label ID="Label37" runat="server" Visible="false" CssClass="h4" Text="Comentario 19:"></asp:Label> 
            <br />  
<asp:Label ID="Label38" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
<asp:Label ID="Label39" runat="server" Visible="false" CssClass="h4" Text="Comentario 20:"></asp:Label>
            <br />
<asp:Label ID="Label40" runat="server" Visible="false" Text="Label"></asp:Label>
            <br />
            
    </div>    
    </div>
    <!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
          <asp:Label ID="Label42" class="modal-title" runat="server" Text="Label"></asp:Label>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Atras</button>
          <asp:Button ID="BtnContinuar" class="btn btn-danger" runat="server" Enabled="true" Text="Eliminar" OnClick="BtnContinuar_Click" />
      </div>
    </div>
  </div>
</div>

</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentAside" Runat="Server">
    <h3> Acciones: </h3>
    <div class="row">
                <div class="col-md-2"></div>
            <asp:Button ID="Button1" CssClass="btn btn-primary col-md-8" runat="server" Text="Editar" />
                </div>
    <div class="row">
        <br />
    </div>
    <div class="row">
                <div class="col-md-2"></div>
            <asp:label ID="Button2" CssClass="btn btn-danger col-md-8" data-toggle="modal" data-target="#myModal" runat="server" Text="Eliminar" />
                </div>
    <div class="row">
        <br />
    </div>
    <div class="row">
                <div class="col-md-2"></div>
            <asp:Button ID="Button3" CssClass="btn btn-default col-md-8" runat="server" Text="Cancelar" />
                </div>

</asp:Content>


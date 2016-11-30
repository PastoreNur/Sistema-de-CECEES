<%@ Page Title="" Language="C#" MasterPageFile="~/Account/PanelAdmin.master" AutoEventWireup="true" CodeFile="AdminDocentes.aspx.cs" Inherits="Account_admin_AdminDocente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="CerrarSesion" Runat="Server">
    
    <asp:Button ID="Sesion" runat="server" Text="Iniciar Sesión" CssClass="btn navbar-btn" />
    

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="NomUsuario" Runat="Server">
 

                     
                      <a class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">
                        <asp:Label ID="LblNomUser" runat="server" Text="Invitado"></asp:Label>
                          <span class="caret"></span></a>
                      


</asp:Content>

    <asp:Content ID="Content5" ContentPlaceHolderID="Panel" Runat="Server">
        <asp:Button ID="PanelAdministracion" runat="server" Text="Administración" CssClass="btn btn-link" />    
        
        
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="btncerrar" runat="server">
    <asp:Button ID="BtnCerrarSesion" runat="server" Text="Cerrar Sesión" CssClass="btn btn-link" />
</asp:Content>


<asp:Content ID="Content6" ContentPlaceHolderID="principal" Runat="Server">


    <div class="row">

        <div class="col-md-5">
            <div class="panel panel-primary">
                <div class="panel-heading ">
                        <h3 class="panel-title">Menú</h3>
                 </div>
                 <div class="panel-body">
                            
                     <asp:Button ID="BtnReturnPanelAdmin" runat="server" Text="Panel de Administración" class="btn btn-block" />
                     
                 </div>
            </div>
        </div>
        

   <div class="col-md-7">
       <div class="panel panel-primary">
           <div class="panel-heading"><asp:Label ID="LblNombrePanel" runat="server" Text="Buscar Docente"></asp:Label></div>
              <div class="panel-body">
                  <div class="row">
                      <div class="col-md-12">
                          <div class="form-group">
                              <asp:Label ID="Label1" runat="server" Text="NIP"></asp:Label>
                              <asp:TextBox ID="txtNIP" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                      </div>
                      <div class="col-md-6">
                      
                          <div class="form-group">
                              <asp:Label ID="Label3" runat="server" Text="Primer Nombre"></asp:Label>
                              <asp:TextBox ID="txtPrimerNombre" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <asp:Label ID="Label4" runat="server" Text="Primer Apellido"></asp:Label>
                              <asp:TextBox ID="txtPrimerApellido" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <asp:Label ID="Label8" runat="server" Text="Especialidad"></asp:Label>
                              <asp:TextBox ID="txtEspecialidad" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          
                           <div class="form-group">
                                <asp:Label ID="lbleducacion" runat="server" visible="false" Text="Educación"></asp:Label>
                                <asp:DropDownList ID="DpdEducacion" runat="server" visible="false" CssClass="form-control">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                    <asp:ListItem>Basica</asp:ListItem>
                                    <asp:ListItem>Bachillerato</asp:ListItem>
                                    <asp:ListItem>Basica y Bachillerato</asp:ListItem>
                                </asp:DropDownList>
                          </div> 

                      </div>

                      <div class="col-md-6">
                          <div class="form-group">
                              <asp:Label ID="Label2" runat="server" Text="Segundo Nombre"></asp:Label>
                              <asp:TextBox ID="txtSegundoNombre" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          <div class="form-group">
                              <asp:Label ID="Label6" runat="server" Text="Segundo Apellido"></asp:Label>
                              <asp:TextBox ID="txtSegundoApellido" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                          
                          <div class="form-group">
                              <asp:Label ID="Label7" runat="server" Text="Teléfono"></asp:Label>
                              <asp:TextBox ID="txtTelefono" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>

                           <div class="form-group">
                                <asp:Label ID="lblturno" runat="server" visible="false" Text="Turno"></asp:Label>
                                <asp:DropDownList ID="DpdTurno" Visible="false" runat="server" CssClass="form-control">
                                    <asp:ListItem Selected="True"></asp:ListItem>
                                    <asp:ListItem>Mañana</asp:ListItem>
                                    <asp:ListItem>Tarde</asp:ListItem>
                                    <asp:ListItem>Mañana y Tarde</asp:ListItem>
                                </asp:DropDownList>
                          </div>

                      </div>
                      
                      <div class="col-md-12"> 
                          <div class="form-group">
                              <asp:Label ID="Label10" runat="server" Text="Dirección"></asp:Label>
                              <asp:TextBox ID="txtDireccion" runat="server" CssClass="form-control"></asp:TextBox>
                          </div>
                      </div>

                      <div class="row">
                          <div class="col-md-6">

                          </div>
                          <div class="col-md-6">

                          </div>
                      </div>

                      <div class="col-md-12">
                           <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" Visible="false" CssClass="btn btn-block btn-primary" OnClick="BtnRegistrar_Click"/>
                         
                           
                               <div class="row">
                                  
                                   <div class="col-md-2">

                                   </div>
                                  <div class="col-md-8">
                                      
                                      <div class="btn btn-group">
                                           <asp:Button ID="BtnBuscar" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click"/>
                                
                                      <asp:Button ID="BtnActualizar" runat="server" Text="Actualizar" CssClass="btn btn-success" OnClick="BtnActualizar_Click"/>
                             
                                      <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="BtnEliminar_Click"/>
                                  
                                      </div>
                                     
                                  </div>
                                   <div class="col-md-1">

                                   </div>
                                
                                   </div>
                            
                        </div>
                         
                     </div>
                      
                  </div>
              </div>
           </div>
       </div>



</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="aside" Runat="Server">
    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-info">
                <div class="panel-heading ">
                        <h3 class="panel-title">Herramientas</h3>
                 </div>
                 <div class="panel-body">
                            
                     <asp:Button ID="BtnRegistrarDocente" runat="server" Text="Registrar Docente" class="btn btn-block btn-primary" OnClick="BtnRegistrarDocente_Click"/>
                     <asp:Label ID="Label5" runat="server" Text="Docentes Registrados" data-toggle="modal" data-target="#tabla" CssClass="btn btn-block btn-primary" ></asp:Label>
                     <asp:Button ID="BtnBuscarDocente" runat="server" Text="Buscar Docente" class="btn btn-block btn-primary" OnClick="BtnBuscarDocente_Click" />
                     
                     
                 </div>
            </div>
        </div>
    </div>

</asp:Content>



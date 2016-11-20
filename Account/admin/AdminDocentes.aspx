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
           <div class="panel-heading"><h3 class="panel-title"><asp:Label ID="Label12" runat="server" Text="Registrar Usuario" ></asp:Label></h3>
           </div>
           <div class="panel-body">
               <div class="form-group">
       <asp:Label ID="Label6" runat="server" Text="Código de Usuario" ></asp:Label>
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
       <asp:Label ID="Label3" runat="server" Text="Tipo de Usuario" ></asp:Label>

         <asp:DropDownList ID="txtTipoUser" runat="server" CssClass="form-control">
             <asp:ListItem>Admin</asp:ListItem>
             <asp:ListItem>Secretaria</asp:ListItem>
             <asp:ListItem>Tesorero</asp:ListItem>
             <asp:ListItem>Docente</asp:ListItem>
             <asp:ListItem>Encargado</asp:ListItem>
             <asp:ListItem>Alumno</asp:ListItem>
         </asp:DropDownList>
    </div>
      <div class="form-group">
       <asp:Label ID="Label4" runat="server" Text="Contraseña" ></asp:Label>
    <asp:TextBox ID="txtPassword" runat="server" class="form-control" TextMode="Password"></asp:TextBox>
    </div>
     
    <asp:Button ID="guardar" runat="server" Text="Registrar" class="btn btn-primary btn-block" OnClick="guardar_Click"/>
    <div class="row">
        <div class="col-md-3"></div>
      <div class="btn-group col-md-7">
      <asp:Button ID="buscar" runat="server" Text="Buscar" class="btn btn-primary" />
     <asp:Button ID="actualizar" runat="server" Text="Actualizar" class="btn btn-primary" />
    <asp:Button ID="eliminar" runat="server" Text="Eliminar" class="btn btn-primary" />
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
                            
                     <asp:Button ID="BtnUsuarios" runat="server" Text="Administrar Usuarios" class="btn btn-block"/>
                     <asp:Label ID="Label5" runat="server" Text="Usuarios Registrados" data-toggle="modal" data-target="#tabla" CssClass="btn btn-block btn-primary" ></asp:Label>
                     <asp:Button ID="BtnGuardarUser" runat="server" Text="Guardar Usuario" class="btn btn-block btn-primary"/>
                     <asp:Button ID="BtnBuscar" runat="server" Text="Buscar Usuario" class="btn btn-block btn-primary" />
                     
                      <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [docentes]" DeleteCommand="DELETE FROM [docentes] WHERE [NIP] = @NIP" InsertCommand="INSERT INTO [docentes] ([NIP], [primer_nombre], [segundo_nombre], [primer_apellido], [segundo_apellido], [especialidad], [direccion], [correo]) VALUES (@NIP, @primer_nombre, @segundo_nombre, @primer_apellido, @segundo_apellido, @especialidad, @direccion, @correo)" UpdateCommand="UPDATE [docentes] SET [primer_nombre] = @primer_nombre, [segundo_nombre] = @segundo_nombre, [primer_apellido] = @primer_apellido, [segundo_apellido] = @segundo_apellido, [especialidad] = @especialidad, [direccion] = @direccion, [correo] = @correo WHERE [NIP] = @NIP">
                          <DeleteParameters>
                              <asp:Parameter Name="NIP" Type="Int32" />
                          </DeleteParameters>
                          <InsertParameters>
                              <asp:Parameter Name="NIP" Type="Int32" />
                              <asp:Parameter Name="primer_nombre" Type="String" />
                              <asp:Parameter Name="segundo_nombre" Type="String" />
                              <asp:Parameter Name="primer_apellido" Type="String" />
                              <asp:Parameter Name="segundo_apellido" Type="String" />
                              <asp:Parameter Name="especialidad" Type="String" />
                              <asp:Parameter Name="direccion" Type="String" />
                              <asp:Parameter Name="correo" Type="String" />
                          </InsertParameters>
                          <UpdateParameters>
                              <asp:Parameter Name="primer_nombre" Type="String" />
                              <asp:Parameter Name="segundo_nombre" Type="String" />
                              <asp:Parameter Name="primer_apellido" Type="String" />
                              <asp:Parameter Name="segundo_apellido" Type="String" />
                              <asp:Parameter Name="especialidad" Type="String" />
                              <asp:Parameter Name="direccion" Type="String" />
                              <asp:Parameter Name="correo" Type="String" />
                              <asp:Parameter Name="NIP" Type="Int32" />
                          </UpdateParameters>
                     </asp:SqlDataSource>
          <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" EnableModelValidation="True" CellPadding="4" ForeColor="#333333" GridLines="None" Width="100%" AllowPaging="True" AllowSorting="True" DataKeyNames="NIP">
              <AlternatingRowStyle BackColor="White" />
              <Columns>
                  <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                  <asp:BoundField DataField="NIP" HeaderText="NIP" SortExpression="NIP" ReadOnly="True" />
                  <asp:BoundField DataField="primer_nombre" HeaderText="primer_nombre" SortExpression="primer_nombre" />
                  <asp:BoundField DataField="segundo_nombre" HeaderText="segundo_nombre" SortExpression="segundo_nombre" />
                  <asp:BoundField DataField="primer_apellido" HeaderText="primer_apellido" SortExpression="primer_apellido" />
                  <asp:BoundField DataField="segundo_apellido" HeaderText="segundo_apellido" SortExpression="segundo_apellido" />
                  <asp:BoundField DataField="especialidad" HeaderText="especialidad" SortExpression="especialidad" />
                  <asp:BoundField DataField="direccion" HeaderText="direccion" SortExpression="direccion" />
                  <asp:BoundField DataField="correo" HeaderText="correo" SortExpression="correo" />
              </Columns>
                     <EditRowStyle BackColor="#2461BF" />
              <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#EFF3FB" />
              <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                     </asp:GridView>

                 </div>
            </div>
        </div>
    </div>


    <div class="modal fade" id="tabla" tabindex="-1" role="dialog">
  <div class="modal-dialog modal-lg" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title">Usuarios registrados</h4>
      </div>
      <div class="modal-body">
         
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Cerrar</button>
       </div>
    </div><!-- /.modal-content -->
  </div><!-- /.modal-dialog -->
</div><!-- /.modal -->
</asp:Content>



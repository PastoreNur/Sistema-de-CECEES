<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="EditarMat.aspx.cs" Inherits="EditarMat" %>

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
     <div class="panel panel-primary">
    <div class="panel-heading">

        <h3>Editar información</h3>

    </div>
    <div class="panel-body">
        <h3>NIE:</h3>
        <asp:Textbox ID="Label54" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
        <br />
<h3>Primer apellido del alumno:</h3>
    <asp:Textbox ID="Label1" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />

            <h3>Segundo apellido del alumno:</h3>
    <asp:Textbox ID="Label2" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Primer nombre del alumno:</h3>
    <asp:Textbox ID="Label3" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Segundo nombre del alumno:</h3>
    <asp:Textbox ID="Label4" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Genero:</h3>
    <asp:Dropdownlist ID="Label5" CssClass="form-control" runat="server" >
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Masculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
    </asp:Dropdownlist>
    <br />
        <h3>Fecha de nacimiento: </h3>
    <asp:Textbox ID="Label6" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Edad: </h3>
    <asp:Textbox ID="Label7" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Lugar de nacimiento: </h3>
    <asp:Textbox ID="Label8" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Zona de residencia:</h3>
    <asp:Dropdownlist ID="Label9" runat="server" CssClass="form-control">
         <asp:ListItem></asp:ListItem>
        <asp:ListItem>Urbano</asp:ListItem>
        <asp:ListItem>Rural</asp:ListItem>
    </asp:Dropdownlist>
    <br />
            <h3>Dirección:</h3>
    <asp:Textbox ID="Label10" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Nacionalidad:</h3>
    <asp:Textbox ID="Label11" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Telefono de casa: </h3>
    <asp:Textbox ID="Label12" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Celular:</h3>
    <asp:Textbox ID="Label13" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Religion que profesa:</h3>
    <asp:Textbox ID="Label14" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Sacramentos con los que cuenta: </h3>
        <div class="col-md-12">
        <div class="col-md-8">
         <asp:CheckBox ID="ChBBautismo" text="Bautismo." cssclass="checkbox" runat="server"></asp:CheckBox>
        <asp:CheckBox ID="ChBPrimeracom" Text="Primera comunión." cssclass="checkbox" runat="server" ></asp:CheckBox>
        <asp:CheckBox ID="ChBConfirmacion" Text="Confirmación" cssclass="checkbox" runat="server" ></asp:CheckBox>
        </div>
                <div class="col-md-2"></div>
            </div>
    <br />
        <h3>El alumno es de nuevo ingreso:</h3>
    <asp:Dropdownlist ID="Label16" CssClass="form-control" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
    <asp:Panel ID="Panel1" visible="false" CssClass="form-control" runat="server">
                        <h4>Institución de procedencia:</h4>
        <asp:Textbox ID="Label17" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel2" Visible="false" CssClass="form-control" runat="server">
                <h4>Grado desde el que estudia aqui:</h4>
        <asp:Textbox ID="Label18" runat="server"  Text="Label"></asp:Textbox>
        <br />

    </asp:Panel>
        <h3>Estudio parvularia:</h3>
    <asp:Dropdownlist ID="Label19" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
        <h3>¿Tiene hermanos estudiando aqui?</h3>
    <asp:Dropdownlist ID="Label20" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
    <asp:Panel ID="Panel3" Visible="false"  runat="server">
                <h3>¿Cuantos?</h3>
        <asp:Textbox ID="Label21" runat="server" Visible="false" CssClass="form-control" Text="Label"></asp:Textbox>
        <br />
        <asp:Label ID="LblGrado1" runat="server" Visible="false" Text="Grado 1"></asp:Label>
            <asp:Textbox ID="TxtGrado1" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado2"  runat="server" Visible="false" Text="Grado 2"></asp:Label>
            <asp:Textbox ID="TxtGrado2" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado3"  runat="server" Visible="false" Text="Grado 3"></asp:Label>
            <asp:Textbox ID="TxtGrado3" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado4"  runat="server" Visible="false" Text="Grado 4"></asp:Label>
            <asp:Textbox ID="TxtGrado4" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado5" runat="server" Visible="false" Text="Grado 5"></asp:Label>
            <asp:Textbox ID="TxtGrado5" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado6" runat="server" Visible="false" Text="Grado 6"></asp:Label>
            <asp:Textbox ID="TxtGrado6" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado7" runat="server" Visible="false" Text="Grado 7"></asp:Label>
            <asp:Textbox ID="TxtGrado7" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado8" runat="server" Visible="false" Text="Grado 8"></asp:Label>
            <asp:Textbox ID="TxtGrado8" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado9" runat="server" Visible="false" Text="Grado 9"></asp:Label>
            <asp:Textbox ID="TxtGrado9" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado10" runat="server" Visible="false" Text="Grado 10"></asp:Label>
            <asp:Textbox ID="TxtGrado10" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado11" runat="server" Visible="false" Text="Grado 11"></asp:Label>
            <asp:Textbox ID="TxtGrado11" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado12" runat="server" Visible="false" Text="Grado 12"></asp:Label>
            <asp:Textbox ID="TxtGrado12" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado13" runat="server" Visible="false" Text="Grado 13"></asp:Label>
            <asp:Textbox ID="TxtGrado13" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado14" runat="server" Visible="false" Text="Grado 14"></asp:Label>
            <asp:Textbox ID="TxtGrado14" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado15" runat="server" Visible="false" Text="Grado 15"></asp:Label>
            <asp:Textbox ID="TxtGrado15" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado16" runat="server" Visible="false" Text="Grado 16"></asp:Label>
            <asp:Textbox ID="TxtGrado16" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado17" runat="server" Visible="false" Text="Grado 17"></asp:Label>
            <asp:Textbox ID="TxtGrado17" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado18" runat="server" Visible="false" Text="Grado 18"></asp:Label>
            <asp:Textbox ID="TxtGrado18" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado19" runat="server" Visible="false" Text="Grado 19"></asp:Label>
            <asp:Textbox ID="TxtGrado19" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
            <asp:Label ID="LblGrado20" runat="server" Visible="false" Text="Grado 20"></asp:Label>
            <asp:Textbox ID="TxtGrado20" CssClass="form-control" Visible="false" runat="server"></asp:Textbox>
           <br />
    </asp:Panel>
            <h2>Información de la madre:</h2>
    <br />
        <h3>Nombre de la madre:</h3>
    <asp:Textbox ID="Label22" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Profesion u oficio:</h3>
    <asp:Textbox ID="Label23" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Lugar de trabajo</h3>
    <asp:Textbox ID="Label24" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Telefono del trabajo:</h3>
    <asp:Textbox ID="Label25" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
    <br />
        <h3>Nombre del padre:</h3>
    <asp:Textbox ID="Label26" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Profesion u oficio:</h3>
    <asp:Textbox ID="Label27" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Lugar de trabajo</h3>
    <asp:Textbox ID="Label28" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Telefono del trabajo:</h3>
    <asp:Textbox ID="Label29" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
      <br />
        <br />
            <h3>Estado civil de los padres:</h3>
    <asp:Dropdownlist ID="Label30" runat="server" CssClass="form-control">
       <asp:ListItem></asp:ListItem>
         <asp:ListItem> Matrimonio Eclesial</asp:ListItem>
            <asp:ListItem> Casados solo civil</asp:ListItem>
            <asp:ListItem> Divorciados</asp:ListItem>
            <asp:ListItem> Separados</asp:ListItem>
            <asp:ListItem> Viuda/o</asp:ListItem>
            <asp:ListItem> Madre soltera</asp:ListItem>
            <asp:ListItem> Padre soltero</asp:ListItem>
            <asp:ListItem> Acompañados</asp:ListItem>
    </asp:Dropdownlist>
     <br />
        <h3>El niño vive con:</h3>
    <asp:Dropdownlist ID="Label31" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>    
        <asp:ListItem>Ambos padres</asp:ListItem>
            <asp:ListItem>Solo papá</asp:ListItem>
            <asp:ListItem>Solo mamá</asp:ListItem>
            <asp:ListItem>Con abuelos</asp:ListItem>
            <asp:ListItem>Otros</asp:ListItem>
    </asp:Dropdownlist>
    <br />
            <h3>¿Posee alguna discapacidad fisica?</h3>
    <asp:Dropdownlist ID="Label32" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
<asp:Panel ID="Panel4" Visible="false" runat="server">
    <br />
            <h3>¿Cual es?</h3>
    <asp:Textbox ID="Label33" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
</asp:Panel>
            <h3>¿El alumno repite grado?</h3>
    <asp:Dropdownlist ID="Label34" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
            <h3>¿Tiene las vacunas completas?</h3>
    <asp:Dropdownlist ID="Label35" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
            <h3>Problemas de salud que padece:</h3>
    <asp:Textbox ID="Label36" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>¿Recibe educación especial?</h3>
    <asp:Dropdownlist ID="Label37" runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
            <h3>¿El alumno realiza algun trabajo remunerado?</h3>
    <asp:Dropdownlist ID="Label38"  runat="server" CssClass="form-control">
        <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
    </asp:Dropdownlist>
    <br />
    <asp:Panel ID="Panel5" Visible="false" runat="server">            
        <h3>¿Cual es?</h3>
        <asp:Textbox ID="Label39" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
        <br />
</asp:Panel>
     <br />
        <br />
        <h2>Personas responsables del rendimiento escolar del de la niño/a y que lo/a pueden RETIRAR de la escuela.</h2>
        <br />
        <h2>Primer responsable:</h2>
        <br />
        <h3>Primer nombre:</h3>
    <asp:Textbox ID="Label40" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Segundo nombre:</h3>
    <asp:Textbox ID="Label41" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Primer apellido:</h3>
    <asp:Textbox ID="Label42" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Segundo apellido:</h3>
    <asp:Textbox ID="Label43" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>DUI:</h3>
    <asp:Textbox ID="Label44" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Telefono:</h3>
    <asp:Textbox ID="Label45" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
            <h3>Celular:</h3>
    <asp:Textbox ID="Label46" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
                   <h2>Segundo Responsable:</h2>
     <br />
        <h3>Primer nombre:</h3>
    <asp:Textbox ID="Label47" CssClass="form-control" runat="server" Text="Label"></asp:Textbox>
    <br />
        <h3>Segundo nombre:</h3>
    <asp:Textbox ID="Label48" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
            <h3>Primer apellido:</h3>
    <asp:Textbox ID="Label49" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Segundo apellido:</h3>
    <asp:Textbox ID="Label50" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
            <h3>DUI:</h3>
    <asp:Textbox ID="Label51" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Telefono:</h3>
    <asp:Textbox ID="Label52" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
        <h3>Celular:</h3>
    <asp:Textbox ID="Label53" runat="server" CssClass="form-control" Text="Label"></asp:Textbox>
    <br />
    
    </div>
    <div class="panel-footer">
        <div class="row">
        <div class="col-md-12">
            <div class="col-md-12">
        <asp:Button ID="Button1" CssClass="col-md-4 btn btn-primary" runat="server" Text="Cancelar" />
                <asp:Label ID="Label57" CssClass="col-md-4 btn btn-default" data-toggle="modal" data-target="#myModal" runat="server" Text="Actualizar"></asp:Label>
           </div>
                 </div>
    </div>
    </div>
    </div>
        <asp:TextBox ID="TxtHermNum" Visible="false" runat="server"></asp:TextBox>


        <!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
          <asp:Label ID="Label55" class="modal-title h4" runat="server" Text="Notificar error."></asp:Label>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label56" runat="server" Text="Comentario:"></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Atras</button>

                  <asp:button ID="Aceptar" runat="server" class="btn btn-primary" text="Enviar" OnClick="Aceptar_Click" />

      </div>
    </div>
  </div>
</div>
</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="ContentAside" Runat="Server">
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="VerificacionMatricula.aspx.cs" Inherits="VerificacionMatricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">

</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="CerrarSesion" Runat="Server">
   
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="panel panel-primary">
    <div class="panel-heading">

        <h3>Verificar información</h3>

    </div>
    <div class="panel-body">
        <h3>NIE:</h3>
        <asp:Label ID="Label54" runat="server" Text="Label"></asp:Label>
        <br />
<h3>Primer apellido del alumno:</h3>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    <br />

            <h3>Segundo apellido del alumno:</h3>
    <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Primer nombre del alumno:</h3>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Segundo nombre del alumno:</h3>
    <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Genero:</h3>
    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Fecha de nacimiento: </h3>
    <asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Edad: </h3>
    <asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Lugar de nacimiento: </h3>
    <asp:Label ID="Label8" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Zona de residencia:</h3>
    <asp:Label ID="Label9" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Dirección:</h3>
    <asp:Label ID="Label10" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Nacionalidad:</h3>
    <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Telefono de casa: </h3>
    <asp:Label ID="Label12" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Celular:</h3>
    <asp:Label ID="Label13" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Religion que profesa:</h3>
    <asp:Label ID="Label14" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Sacramentos con los que cuenta: </h3>
    <asp:Label ID="Label15" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>El alumno es de nuevo ingreso:</h3>
    <asp:Label ID="Label16" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Panel ID="Panel1" visible="false" runat="server">
                        <h4>Institución de procedencia:</h4>
        <asp:Label ID="Label17" runat="server" Text="Label"></asp:Label>
        <br />
    </asp:Panel>
    <asp:Panel ID="Panel2" Visible="false" runat="server">
                <h4>Grado desde el que estudia aqui:</h4>
        <asp:Label ID="Label18" runat="server" Text="Label"></asp:Label>
        <br />

    </asp:Panel>
        <h3>Estudio parvularia:</h3>
    <asp:Label ID="Label19" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>¿Tiene hermanos estudiando aqui?</h3>
    <asp:Label ID="Label20" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Panel ID="Panel3" Visible="false" runat="server">
                <h3>¿Cuantos?</h3>
        <asp:Label ID="Label21" runat="server" Visible="false" Text="Label"></asp:Label>
        <br />
        <asp:Label ID="LblGrado1" cssclass="form-control" runat="server" Visible="false" Text="Grado 1"></asp:Label>
            <asp:Label ID="TxtGrado1" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado2" cssclass="form-control" runat="server" Visible="false" Text="Grado 2"></asp:Label>
            <asp:Label ID="TxtGrado2" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado3" cssclass="form-control" runat="server" Visible="false" Text="Grado 3"></asp:Label>
            <asp:Label ID="TxtGrado3" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado4" cssclass="form-control" runat="server" Visible="false" Text="Grado 4"></asp:Label>
            <asp:Label ID="TxtGrado4" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado5" cssclass="form-control" runat="server" Visible="false" Text="Grado 5"></asp:Label>
            <asp:Label ID="TxtGrado5" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado6" cssclass="form-control" runat="server" Visible="false" Text="Grado 6"></asp:Label>
            <asp:Label ID="TxtGrado6" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado7" cssclass="form-control" runat="server" Visible="false" Text="Grado 7"></asp:Label>
            <asp:Label ID="TxtGrado7" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado8" cssclass="form-control" runat="server" Visible="false" Text="Grado 8"></asp:Label>
            <asp:Label ID="TxtGrado8" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado9" cssclass="form-control" runat="server" Visible="false" Text="Grado 9"></asp:Label>
            <asp:Label ID="TxtGrado9" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado10" cssclass="form-control" runat="server" Visible="false" Text="Grado 10"></asp:Label>
            <asp:Label ID="TxtGrado10" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado11" cssclass="form-control" runat="server" Visible="false" Text="Grado 11"></asp:Label>
            <asp:Label ID="TxtGrado11" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado12" cssclass="form-control" runat="server" Visible="false" Text="Grado 12"></asp:Label>
            <asp:Label ID="TxtGrado12" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado13" cssclass="form-control" runat="server" Visible="false" Text="Grado 13"></asp:Label>
            <asp:Label ID="TxtGrado13" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado14" cssclass="form-control" runat="server" Visible="false" Text="Grado 14"></asp:Label>
            <asp:Label ID="TxtGrado14" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado15" cssclass="form-control" runat="server" Visible="false" Text="Grado 15"></asp:Label>
            <asp:Label ID="TxtGrado15" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado16" cssclass="form-control" runat="server" Visible="false" Text="Grado 16"></asp:Label>
            <asp:Label ID="TxtGrado16" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado17" cssclass="form-control" runat="server" Visible="false" Text="Grado 17"></asp:Label>
            <asp:Label ID="TxtGrado17" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado18" cssclass="form-control" runat="server" Visible="false" Text="Grado 18"></asp:Label>
            <asp:Label ID="TxtGrado18" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado19" cssclass="form-control" runat="server" Visible="false" Text="Grado 19"></asp:Label>
            <asp:Label ID="TxtGrado19" CssClass="form-control" Visible="false" runat="server"></asp:Label>
            <asp:Label ID="LblGrado20" cssclass="form-control" runat="server" Visible="false" Text="Grado 20"></asp:Label>
            <asp:Label ID="TxtGrado20" CssClass="form-control" Visible="false" runat="server"></asp:Label>
           <br />
    </asp:Panel>
            <h2>Información de la madre:</h2>
    <br />
        <h3>Nombre de la madre:</h3>
    <asp:Label ID="Label22" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Profesion u oficio:</h3>
    <asp:Label ID="Label23" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Lugar de trabajo</h3>
    <asp:Label ID="Label24" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Telefono del trabajo:</h3>
    <asp:Label ID="Label25" runat="server" Text="Label"></asp:Label>
    <br />
    <br />
        <h3>Nombre del padre:</h3>
    <asp:Label ID="Label26" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Profesion u oficio:</h3>
    <asp:Label ID="Label27" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Lugar de trabajo</h3>
    <asp:Label ID="Label28" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Telefono del trabajo:</h3>
    <asp:Label ID="Label29" runat="server" Text="Label"></asp:Label>
    <br />
      <br />
        <br />
            <h3>Estado civil de los padres:</h3>
    <asp:Label ID="Label30" runat="server" Text="Label"></asp:Label>
     <br />
        <h3>El niño vive con:</h3>
    <asp:Label ID="Label31" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>¿Posee alguna discapacidad fisica?</h3>
    <asp:Label ID="Label32" runat="server" Text="Label"></asp:Label>
    <br />
<asp:Panel ID="Panel4" Visible="false" runat="server">
    <br />
            <h3>¿Cual es?</h3>
    <asp:Label ID="Label33" runat="server" Text="Label"></asp:Label>
    <br />
</asp:Panel>
            <h3>¿El alumno repite grado?</h3>
    <asp:Label ID="Label34" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>¿Tiene las vacunas completas?</h3>
    <asp:Label ID="Label35" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Problemas de salud que padece:</h3>
    <asp:Label ID="Label36" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>¿Recibe educación especial?</h3>
    <asp:Label ID="Label37" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>¿El alumno realiza algun trabajo remunerado?</h3>
    <asp:Label ID="Label38" runat="server" Text="Label"></asp:Label>
    <br />
    <asp:Panel ID="Panel5" Visible="false" runat="server">            
        <h3>¿Cual es?</h3>
        <asp:Label ID="Label39" runat="server" Text="Label"></asp:Label>
        <br />
</asp:Panel>
     <br />
        <br />
        <h2>Personas responsables del rendimiento escolar del de la niño/a y que lo/a pueden RETIRAR de la escuela.</h2>
        <br />
        <h2>Primer responsable:</h2>
        <br />
        <h3>Primer nombre:</h3>
    <asp:Label ID="Label40" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Segundo nombre:</h3>
    <asp:Label ID="Label41" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Primer apellido:</h3>
    <asp:Label ID="Label42" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Segundo apellido:</h3>
    <asp:Label ID="Label43" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>DUI:</h3>
    <asp:Label ID="Label44" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Telefono:</h3>
    <asp:Label ID="Label45" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Celular:</h3>
    <asp:Label ID="Label46" runat="server" Text="Label"></asp:Label>
    <br />
                   <h2>Segundo Responsable:</h2>
     <br />
        <h3>Primer nombre:</h3>
    <asp:Label ID="Label47" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Segundo nombre:</h3>
    <asp:Label ID="Label48" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>Primer apellido:</h3>
    <asp:Label ID="Label49" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Segundo apellido:</h3>
    <asp:Label ID="Label50" runat="server" Text="Label"></asp:Label>
    <br />
            <h3>DUI:</h3>
    <asp:Label ID="Label51" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Telefono:</h3>
    <asp:Label ID="Label52" runat="server" Text="Label"></asp:Label>
    <br />
        <h3>Celular:</h3>
    <asp:Label ID="Label53" runat="server" Text="Label"></asp:Label>
    <br />
    
    </div>
    <div class="panel-footer">
        <div class="row">
        <div class="col-md-12">
            <div class="col-md-12">
        <asp:Button ID="Button3" CssClass="col-md-4 btn btn-danger" runat="server" Text="Eliminar" OnClick="Button3_Click" />
        <asp:Button ID="Button1" CssClass="col-md-4 btn btn-primary" runat="server" Text="Verificar" />
                <asp:Label ID="Label57" CssClass="col-md-4 btn btn-default" data-toggle="modal" data-target="#myModal" runat="server" Text="Notificar error"></asp:Label>
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
          <asp:Label ID="Label55" class="modal-title h4" runat="server" Text="Label"></asp:Label>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label56" runat="server" Text=""></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Atras</button>

                  <asp:button ID="Aceptar" runat="server" class="btn btn-primary" text="Enviar" OnClick="Aceptar_Click" />

      </div>
    </div>
  </div>
</div>

</asp:Content>


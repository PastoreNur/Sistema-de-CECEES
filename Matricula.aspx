<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Matricula.aspx.cs" Inherits="Matricula" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <style>
        .articulo-principal {
    background-color:white;
        }
        .checkbox{
            padding-left: 25px;
        }
    </style>


    <div class="form-registro">
        <h3>NIE:</h3>
        <asp:TextBox ID="TxtNIE" CssClass="form-control" placeholder="NIE" runat="server"></asp:TextBox>
        <br />
<h3>Primer apellido del alumno:</h3>
        
        <asp:TextBox ID="TxtApellidoAlum1" CssClass="form-control" placeholder="Apellidos" runat="server"></asp:TextBox>
    <br />
        <h3>Segundo apellido del alumno:</h3>
        <asp:TextBox ID="TxtApellidoAlum2" CssClass="form-control" placeholder="Apellidos" runat="server"></asp:TextBox>
    <br />
    <h3>Primer nombre del alumno:</h3>
    <asp:TextBox ID="TxtNombreAlum1" CssClass="form-control" placeholder="Nombres" runat="server"></asp:TextBox>
    <br />

        <h3>Segundo nombre del alumno:</h3>
    <asp:TextBox ID="TxtNombreAlum2" CssClass="form-control" placeholder="Nombres" runat="server"></asp:TextBox>
    <br />
    <h3>Genero:</h3>
    <asp:DropDownList ID="DdlGenero" CssClass="form-control" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Masculino</asp:ListItem>
        <asp:ListItem>Femenino</asp:ListItem>
    </asp:DropDownList>
    <br />
    <h3>Fecha de nacimiento: </h3>
    <asp:TextBox ID="TxtNacimento" Cssclass="form-control" placeholder="Dia/Mes/Año" runat="server"></asp:TextBox>
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
        <h3>Dirección:</h3>
    <asp:TextBox ID="TxtDireccion" cssclass="form-control" placeholder="Dirección" runat="server"></asp:TextBox>
    <br />
    <br />
    <h3>Nacionalidad:</h3>
    <asp:TextBox ID="TxtNacionalidad" cssclass="form-control" placeholder="Nacionalidad" runat="server"></asp:TextBox>
    <br />
    <h3>Telefono de casa: </h3>
    <asp:TextBox ID="TxtTelCasa" cssclass="form-control" placeholder="Telefono de casa" runat="server"></asp:TextBox>
    <br />
    <h3>Celular:</h3>
    <asp:TextBox ID="TxtCel" CssClass="form-control" placeholder="Celular" runat="server"></asp:TextBox>
    <br />
    <h3>Religion que profesa:</h3>
    <asp:TextBox ID="TxtReligion" Cssclass="form-control" placeholder="Religión" runat="server"></asp:TextBox>
    <br />
    <h3>Sacramentos con los que cuenta: </h3>
        
        <asp:CheckBox ID="ChBBautismo" text="Bautismo." cssclass="checkbox" runat="server"></asp:CheckBox>
        <asp:CheckBox ID="ChBPrimeracom" Text="Primera comunión." cssclass="checkbox" runat="server" ></asp:CheckBox>
        <asp:CheckBox ID="ChBConfirmacion" Text="Confirmación" cssclass="checkbox" runat="server" ></asp:CheckBox>
        
    <br />
    <h3>El alumno es de nuevo ingreso:</h3>
    <asp:dropdownlist ID="DdlIngreso" cssclass="form-control" runat="server" OnTextChanged="Unnamed1_TextChanged" AutoPostBack="True">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:dropdownlist>
    <br />
    <asp:Panel ID="PnlNuevo" runat="server" Visible="false">

        <h4>Institución de procedencia:</h4>
        <asp:TextBox ID="TxtInstproc" CssClass="form-control" placeholder="Instituciòn de procedencia." runat="server"></asp:TextBox>

    </asp:Panel>
    <asp:Panel ID="PnlAntiguo"  Visible="false" runat="server">

        <h4>Grado desde el que estudia aqui:</h4>
        <asp:TextBox ID="TxtGradodesde" CssClass="form-control" runat="server"></asp:TextBox>
        <br />

    </asp:Panel>
    <br />
    <h3>Estudio parvularia:</h3>
    <asp:DropDownList ID="DdlParvularia" CssClass="form-control" runat="server">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:DropDownList>
    <br />
    <h3>¿Tiene hermanos estudiando aqui?</h3>
    <asp:DropDownList ID="DdlHermanos" CssClass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DdlHermanos_SelectedIndexChanged1">
        <asp:ListItem></asp:ListItem>
        <asp:ListItem>Si</asp:ListItem>
        <asp:ListItem>No</asp:ListItem>
    </asp:DropDownList>

        <asp:panel ID="PanelHermanos" visible="false" runat="server">

        <h3>¿Cuantos?</h3>
    <asp:TextBox ID="TxtHermNum" cssclass="form-control"  placeholder="Cantidad de hermanos" runat="server"></asp:TextBox>
          
            <asp:Label ID="Label2" runat="server" visible="false" Text="En las siguientes casillas escriba el numero del grado a los que los hermanos del alumno asisten."></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Visible="false" Text="Ejemplo: Si uno de ellos asiste a tercero escriba 3, Y si asiste a primer año de bachillerato escriba b1."></asp:Label>
            <br />
            <asp:Label ID="LblGrado1" cssclass="form-control" runat="server" Visible="false" Text="Grado 1"></asp:Label>
            <asp:TextBox ID="TxtGrado1" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado2" cssclass="form-control" runat="server" Visible="false" Text="Grado 2"></asp:Label>
            <asp:TextBox ID="TxtGrado2" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado3" cssclass="form-control" runat="server" Visible="false" Text="Grado 3"></asp:Label>
            <asp:TextBox ID="TxtGrado3" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado4" cssclass="form-control" runat="server" Visible="false" Text="Grado 4"></asp:Label>
            <asp:TextBox ID="TxtGrado4" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado5" cssclass="form-control" runat="server" Visible="false" Text="Grado 5"></asp:Label>
            <asp:TextBox ID="TxtGrado5" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado6" cssclass="form-control" runat="server" Visible="false" Text="Grado 6"></asp:Label>
            <asp:TextBox ID="TxtGrado6" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado7" cssclass="form-control" runat="server" Visible="false" Text="Grado 7"></asp:Label>
            <asp:TextBox ID="TxtGrado7" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
      
            <asp:Label ID="LblGrado8" cssclass="form-control" runat="server" Visible="false" Text="Grado 8"></asp:Label>
         
            
            <asp:TextBox ID="TxtGrado8" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
        
            <asp:Label ID="LblGrado9" cssclass="form-control" runat="server" Visible="false" Text="Grado 9"></asp:Label>

            <asp:TextBox ID="TxtGrado9" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
          
            <asp:Label ID="LblGrado10" cssclass="form-control" runat="server" Visible="false" Text="Grado 10"></asp:Label>
                      <asp:TextBox ID="TxtGrado10" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado11" cssclass="form-control" runat="server" Visible="false" Text="Grado 11"></asp:Label>
            <asp:TextBox ID="TxtGrado11" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado12" cssclass="form-control" runat="server" Visible="false" Text="Grado 12"></asp:Label>
            <asp:TextBox ID="TxtGrado12" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado13" cssclass="form-control" runat="server" Visible="false" Text="Grado 13"></asp:Label>
            <asp:TextBox ID="TxtGrado13" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado14" cssclass="form-control" runat="server" Visible="false" Text="Grado 14"></asp:Label>
            <asp:TextBox ID="TxtGrado14" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            <asp:Label ID="LblGrado15" cssclass="form-control" runat="server" Visible="false" Text="Grado 15"></asp:Label>
            <asp:TextBox ID="TxtGrado15" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
           
            <asp:Label ID="LblGrado16" cssclass="form-control" runat="server" Visible="false" Text="Grado 16"></asp:Label>
            <asp:TextBox ID="TxtGrado16" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            
            <asp:Label ID="LblGrado17" cssclass="form-control" runat="server" Visible="false" Text="Grado 17"></asp:Label>
            <asp:TextBox ID="TxtGrado17" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
           
            <asp:Label ID="LblGrado18" cssclass="form-control" runat="server" Visible="false" Text="Grado 18"></asp:Label>
            <asp:TextBox ID="TxtGrado18" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
           
            <asp:Label ID="LblGrado19" cssclass="form-control" runat="server" Visible="false" Text="Grado 19"></asp:Label>
            <asp:TextBox ID="TxtGrado19" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
            
            <asp:Label ID="LblGrado20" cssclass="form-control" runat="server" Visible="false" Text="Grado 20"></asp:Label>
            <asp:TextBox ID="TxtGrado20" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
           
        <asp:Button ID="Enviar" cssclass="form-control" runat="server" Text="Aceptar" OnClick="Enviar_Click"></asp:Button>
        <br />
            <asp:Button ID="BtnAceptarHerm" CssClass="form-control" Visible="false" runat="server" Text="Aceptar" />
    </asp:panel>
    <br />
    <br />
        <h2>Información de la madre:</h2>
        <br />
        <h3>Nombre de la madre:</h3>
        <asp:textbox ID="TxtNomMadre" placeholder="Nombre" cssclass="form-control"  runat="server"></asp:textbox>
        <br />
        <h3>Profesion u oficio:</h3>
        <asp:textbox ID="TxtProfMadre" cssclass="form-control"  runat="server"></asp:textbox>
        <br />
        <h3>Lugar de trabajo</h3>
        <asp:textbox ID="TxtLugTrabMadre" cssclass="form-control" runat="server"></asp:textbox>
         <br />
        <h3>Telefono del trabajo:</h3>
        <asp:textbox ID="TxtTelTrabMadre" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h2>Información del padre:</h2>
        <br />
        <h3>Nombre del padre:</h3>
        <asp:textbox ID="TxtNomPadre" placeholder="Nombre" cssclass="form-control"  runat="server"></asp:textbox>
        <br />
        <h3>Profesion u oficio:</h3>
        <asp:textbox ID="TxtProfPadre" cssclass="form-control"  runat="server"></asp:textbox>
        <br />
        <h3>Lugar de trabajo</h3>
        <asp:textbox ID="TxtLugTrabPadre" cssclass="form-control" runat="server"></asp:textbox>
         <br />
        <h3>Telefono del trabajo:</h3>
        <asp:textbox ID="TxtTelTrabPadre" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <br />
        <h3>Estado civil de los padres:</h3>
        <asp:radiobuttonlist ID="RblStadCivil" runat="server">
            <asp:ListItem> Matrimonio Eclesial</asp:ListItem>
            <asp:ListItem> Casados solo civil</asp:ListItem>
            <asp:ListItem> Divorciados</asp:ListItem>
            <asp:ListItem> Separados</asp:ListItem>
            <asp:ListItem> Viuda/o</asp:ListItem>
            <asp:ListItem> Madre soltera</asp:ListItem>
            <asp:ListItem> Padre soltero</asp:ListItem>
            <asp:ListItem> Acompañados</asp:ListItem>
        </asp:radiobuttonlist>
        <br />
        <h3>El niño vive con:</h3>
        <asp:radiobuttonlist ID="RblVivecon" runat="server" OnSelectedIndexChanged="RblVivecon_SelectedIndexChanged" AutoPostBack="True">
            <asp:ListItem>Ambos padres</asp:ListItem>
            <asp:ListItem>Solo papá</asp:ListItem>
            <asp:ListItem>Solo mamá</asp:ListItem>
            <asp:ListItem>Con abuelos</asp:ListItem>
            <asp:ListItem>Otros</asp:ListItem>
        </asp:radiobuttonlist>
        
       
        <br />
        <h3>¿Posee alguna discapacidad fisica?</h3>
        <asp:dropdownlist ID="DdlDiscp" cssclass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="Unnamed1_SelectedIndexChanged">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
            
        </asp:dropdownlist>

        <asp:panel ID="PanelDisc" visible="false" runat="server">
            <br />
            <h3>¿Cual es?</h3>
        <asp:TextBox ID="TxtDisc" cssclass="form-control" runat="server"></asp:TextBox>
        </asp:panel>
        <br />
        <h3>¿El alumno repite grado?</h3>
        <asp:dropdownlist ID="DdlAlumRep" cssclass="form-control" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:dropdownlist>
        <br />
        <h3>¿Tiene las vacunas completas?</h3>
        <asp:dropdownlist ID="DdlAlumVacunas" cssclass="form-control" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:dropdownlist>
        <br />
        <h3>Problemas de salud que padece:</h3>
        <asp:textbox ID="TxtProbSalud" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>¿Recibe educación especial?</h3>
        <asp:dropdownlist ID="DdlSpecial" cssclass="form-control" runat="server">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:dropdownlist>
        <br />
        <h3>¿El alumno realiza algun trabajo remunerado?</h3>
        <asp:dropdownlist ID="DdlTrabAlum" cssclass="form-control" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DdlTrabAlum_SelectedIndexChanged">
            <asp:ListItem></asp:ListItem>
            <asp:ListItem>Si</asp:ListItem>
            <asp:ListItem>No</asp:ListItem>
        </asp:dropdownlist>
        <br />
        <asp:panel ID="PanelTrabajo" visible="false" runat="server">

            <h3>¿Cual es?</h3>
        <asp:TextBox ID="TxtTrabAlum" cssclass="form-control" runat="server"></asp:TextBox>
            <br />
        </asp:panel>
        <br />
        <br />
        <h2>Personas responsables del rendimiento escolar del de la niño/a y que lo/a pueden RETIRAR de la escuela.</h2>
        <br />
        <h2>Primer responsable:</h2>
        <br />
        <h3>Primer nombre:</h3>
        <asp:textbox ID="TxtNom1Responsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Segundo nombre:</h3>
        <asp:textbox ID="TxtNom2Responsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Primer apellido:</h3>
        <asp:textbox ID="TxtApell1Responsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Segundo apellido:</h3>
        <asp:textbox ID="TxtApell2Responsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>DUI:</h3>
        <asp:textbox ID="TxtDUIResponsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>Telefono:</h3>
        <asp:textbox ID="TxtTelResponsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
 
        <h3>Celular:</h3>
        <asp:textbox ID="TxtCelularResponsable" cssclass="form-control" runat="server"></asp:textbox>
        <br />
               <h2>Segundo Responsable:</h2>
        <br />
         <br />
        <h3>Primer nombre:</h3>
        <asp:textbox ID="TxtNom1Responsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Segundo nombre:</h3>
        <asp:textbox ID="TxtNom2Responsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Primer apellido:</h3>
        <asp:textbox ID="TxtApell1Responsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <h3>Segundo apellido:</h3>
        <asp:textbox ID="TxtApell2Responsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>DUI:</h3>
        <asp:textbox ID="TxtDUIResponsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>Telefono:</h3>
        <asp:textbox ID="TxtTelResponsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <h3>Celular:</h3>
        <asp:textbox ID="TxtCelularResponsable1" cssclass="form-control" runat="server"></asp:textbox>
        <br />
        <br />
        <asp:button ID="Cancelar" cssclass="form-control" runat="server" text="Cancelar" />

        <asp:Button ID="Verificar" runat="server" CssClass="form-control" Text="Verificar" OnClick="Verificar_Click" />

        <asp:Label ID="BtnVer" CssClass="btn btn-danger form-control" runat="server" data-toggle="modal" data-target="#myModal" Visible="false" Text="Ver"></asp:Label>
        <!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
          <asp:Label ID="Label5" class="modal-title h4" runat="server" Text="Label"></asp:Label>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label4" runat="server" Text=""></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Atras</button>

                  <asp:button ID="Aceptar" runat="server" class="btn btn-primary" text="Enviar" OnClick="Aceptar_Click" />

      </div>
    </div>
  </div>
</div>

        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        <script>
        window.onload=function(){
        var pos=window.name || 0;
        window.scrollTo(0,pos);
        }
        window.onunload=function(){
        window.name=self.pageYOffset || (document.documentElement.scrollTop+document.body.scrollTop);
        }
</script>

        </div>
</asp:Content>


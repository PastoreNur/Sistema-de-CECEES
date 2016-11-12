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
        <br />
        <asp:Button ID="Enviar" cssclass="form-control" runat="server" Text="Aceptar" OnClick="Enviar_Click"></asp:Button>
        <br />

    </asp:panel>
    <br />
    <br />
   
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


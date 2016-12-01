<%@ Page Title="" Language="C#" MasterPageFile="~/Account/PanelAdmin.master" AutoEventWireup="true" CodeFile="materias.aspx.cs" Inherits="Account_materias" %>

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
<asp:Content ID="Content6" ContentPlaceHolderID="principal" Runat="Server">

    <div class="row">

        <div class="col-md-2">

        </div>

        <div class="col-md-8">
            <div class="panel panel-primary">
                <div class="panel-heading">
                    <asp:Label ID="lblNombrepanelMateria" runat="server" Text="Registrar Materia" CssClass="panel-title"></asp:Label>
                </div>
                <div class="panel-body">

                    <div class="row">
                        <div class="col-md-8">
                            <div class="form-group">
                                  <asp:Label ID="Label2" runat="server" Text="Nombre de Materia"></asp:Label>
                                  <asp:TextBox ID="txtNomMateria" runat="server" CssClass="form-control"></asp:TextBox>
                            </div>
                        </div>
                        <div class="col-md-4">
                                <div class="form-group">
                                    <asp:Label ID="Label4" runat="server" Text="Asignatura para"></asp:Label>
                                    <asp:DropDownList ID="DpdTipoMateria" runat="server" CssClass="form-control">
                                        <asp:ListItem Selected="True"></asp:ListItem>
                                        <asp:ListItem>Basica</asp:ListItem>
                                        <asp:ListItem>Basica y Bachillerato</asp:ListItem>
                                        <asp:ListItem>Bachillerato</asp:ListItem>
                                    </asp:DropDownList>  
                                </div>
                            </div>
                        </div>
                    </div>

                <div class="panel-footer">
                    <div class="row">
                        <div class="col-md-3">

                        </div>
                        <div class="col-md-6">
                            
                                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="BtnRegistrar_Click"  />
                            <asp:Button ID="BtnBuscar" visible="false" runat="server" Text="Buscar" CssClass="btn btn-primary" />    
                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger"  />
                                 
                            
                        </div>
                        <div class="col-md-3">

                        </div>

                    </div>
                </div>
            </div>
        </div>

        <div class="col-md-2">

        </div>



    </div>

</asp:Content>
<asp:Content ID="Content7" ContentPlaceHolderID="aside" Runat="Server">

    <div class="panel panel-primary">
        <div class="panel-heading">
            <asp:Label ID="Label1" runat="server" Text="Herramientas" CssClass="panel-title"></asp:Label>
        </div>
        <div class="panel-body">

            <asp:Button ID="BtnMateriasRegistradas" runat="server" Text="Materias Registradas" CssClass="btn-block btn btn-primary" />
            <asp:Button ID="BtnRegistrarMaterias" runat="server" Text="Registrar Materia" CssClass="btn-block btn btn-primary"/>
            
        </div>

    </div>

</asp:Content>




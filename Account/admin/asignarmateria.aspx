<%@ Page Title="" Language="C#" MasterPageFile="~/Account/PanelAdmin.master" AutoEventWireup="true" CodeFile="asignarmateria.aspx.cs" Inherits="Account_admin_asignarmateria" %>

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
                        <div class="col-md-12">
                            <div class="form-group">
                                <asp:Label ID="Label2" runat="server" Text="seleccione un grado/año"></asp:Label>
                                <asp:DropDownList ID="DpdGradosRegistrados" runat="server" CssClass="form-control"></asp:DropDownList>  
                            </div>
                            <div class="form-group">
                                 <asp:Label ID="Label3" runat="server" Text="seleccione la materia que va a asignar"></asp:Label>
                                 <asp:DropDownList ID="DpdMateria" runat="server" CssClass="form-control"></asp:DropDownList>  
                            </div>
                            <div class="form-group">
                                 <asp:Label ID="Label4" runat="server" Text="seleccione al docente que impartirá la clase"></asp:Label>
                                <asp:DropDownList ID="DpdDocente" runat="server" CssClass="form-control"></asp:DropDownList>  
                            </div>
                            

                            <div class="row">
                                <div class="col-md-6">
                                    <asp:Label ID="Label5" runat="server" Text="seleccione el día"></asp:Label>
                                    <asp:DropDownList ID="DpdDiaSemana" runat="server" CssClass="form-control">
                                        <asp:ListItem Selected="True"></asp:ListItem>
                                        <asp:ListItem>Lunes</asp:ListItem>
                                        <asp:ListItem>Martes</asp:ListItem>
                                        <asp:ListItem>Miercoles</asp:ListItem>
                                        <asp:ListItem>Jueves</asp:ListItem>
                                        <asp:ListItem>Viernes</asp:ListItem>
                                    </asp:DropDownList>  
                                </div>
                                <div class="col-md-6">
                                    <asp:Label ID="Label6" runat="server" Text="seleccione la hora"></asp:Label>
                                    <asp:DropDownList ID="DpdHora" runat="server" CssClass="form-control">
                                        <asp:ListItem Selected="True"></asp:ListItem>
                                        <asp:ListItem>7:00 - 7:45</asp:ListItem>
                                        <asp:ListItem>7:45 - 8:30</asp:ListItem>
                                        <asp:ListItem>8:50 - 9:35 </asp:ListItem>
                                        <asp:ListItem>9:35 - 10:20</asp:ListItem>
                                        <asp:ListItem>10:30 - 11:15</asp:ListItem>
                                        <asp:ListItem>11:15 - 12:00</asp:ListItem>
                                        <asp:ListItem>12:30 - 1:15</asp:ListItem>
                                        <asp:ListItem>1:15 - 2:00</asp:ListItem>
                                        <asp:ListItem>2:15 - 3:00</asp:ListItem>
                                        <asp:ListItem>3:00 - 3:45</asp:ListItem>
                                    </asp:DropDownList>  
                                </div>
                            </div>


                        </div>
                    </div>
                    
                   

                    
                    
                </div>
                <div class="panel-footer">
                    <div class="row">
                        <div class="col-md-3">

                        </div>
                        <div class="col-md-6">
                            
                            <asp:Button ID="BtnAsignar" runat="server" Text="Asignar materia" CssClass="btn btn-primary" OnClick="BtnAsignar_Click" />
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


﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Account/PanelAdmin.master" AutoEventWireup="true" CodeFile="Docente.aspx.cs" Inherits="Account_Docente" %>




<asp:Content ID="Content1" ContentPlaceHolderID="principal" Runat="Server">

    <div class="row">

            <div class="col-md-3">
                <div class="panel panel-primary">
                    <div class="panel-heading ">
                        <h5 class="panel-title"><span class="glyphicon glyphicon-user"></span> Alumnos</h5>

                    </div>
                    <div class="panel-body">
                        <asp:Button ID="BtnAdministrarALumnos" runat="server" Text="Administrar" class="btn btn-block btn-primary"/>
                    </div>
                </div>
               </div>

            <div class="col-md-3">
                <div class="panel panel-primary">
                    <div class="panel-heading ">
                        <h5 class="panel-title"><span class="glyphicon glyphicon-calendar"></span> Horarios</h5>

                    </div>
                    <div class="panel-body">
                         <asp:Button ID="BtnAdminsitarHorarios" runat="server" Text="Administrar" class="btn btn-block btn-primary"/>
                    </div>
                </div>
            </div>

         <div class="col-md-3">
                <div class="panel panel-primary">
                    <div class="panel-heading ">
                        <h5 class="panel-title"><span class="glyphicon glyphicon-list-alt"></span> Notas</h5>

                    </div>
                    <div class="panel-body">
                          <asp:Button ID="BtnAdministrarNotas" runat="server" Text="Administrar" class="btn btn-block btn-primary"/>
                    </div>
                </div>
               </div>

         <div class="col-md-3">
                <div class="panel panel-primary">
                    <div class="panel-heading ">
                        <h3 class="panel-title"><span class="glyphicon glyphicon-usd"></span> Pagos</h3>

                    </div>
                    <div class="panel-body">
                        <asp:Button ID="BtnAdministrarPagos" runat="server" Text="Administrar" class="btn btn-block btn-primary"/>
                    </div>
                </div>
         </div>


    </div>

    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="aside" Runat="Server">

    <div class="row">
        <div class="col-md-12">
            <div class="panel panel-info">
                <div class="panel-heading ">
                        <h3 class="panel-title">Herramientas</h3>
                 </div>
                 <div class="panel-body">
                            
                     
     
                 </div>
            </div>
        </div>
    </div>

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

<asp:Content ID="Content6" ContentPlaceHolderID="btncerrar" runat="server">
    <asp:Button ID="BtnCerrarSesion" runat="server" Text="Cerrar Sesión" CssClass="btn btn-link"  />
</asp:Content>




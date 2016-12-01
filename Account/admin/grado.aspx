<%@ Page Title="" Language="C#" MasterPageFile="~/Account/PanelAdmin.master" AutoEventWireup="true" CodeFile="grado.aspx.cs" Inherits="Account_grado" %>

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
                    <asp:Label ID="lblNombrepanelGrado" runat="server" Text="Grados Registrados" CssClass="panel-title"></asp:Label>
                </div>
                <div class="panel-body">

                    <div class="row">

                        <div class="col-md-12">
                            <asp:GridView ID="GradosRegistradosGV"  runat="server" CellPadding="4" EnableModelValidation="True" ForeColor="#333333" GridLines="None" Width="100%" >
                        <AlternatingRowStyle BackColor="White" />
                        <EditRowStyle BackColor="#2461BF" />
                        <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                        <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                        <RowStyle BackColor="#EFF3FB" />
                        <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                        
                    </asp:GridView>
                        </div>

                        <div class="col-md-12">
                            <div class="row">

                                <div class="col-md-9">
                                    <div class="form-group">
                                 
                                        <asp:Label ID="lblNomG" visible="false" runat="server" Text="Nombre"></asp:Label>
                                        <asp:DropDownList ID="DpdNomGrado" visible="false" runat="server" CssClass="form-control"></asp:DropDownList>
                                        
                                                
                                     </div>
                                </div>
                                <div class="col-md-3">
                                    <asp:Label ID="lblHorasClase" runat="server" Text="H/C diarias"></asp:Label>
                                    <asp:TextBox ID="txtHorasClasesEdit" CssClass="form-control" runat="server"></asp:TextBox>
                                </div>

                            </div>


                            <div class="row">
                                <div class="col-md-4">

                                     <div class="form-group">
                                        <asp:Label ID="Label" runat="server" Text="Educación"></asp:Label>
                                        <asp:DropDownList ID="DpdEducacion" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DpdEducacion_SelectedIndexChanged">
                                            <asp:ListItem Selected="True"></asp:ListItem>
                                            <asp:ListItem>Basica</asp:ListItem>
                                            <asp:ListItem>Bachillerato</asp:ListItem>
                                         </asp:DropDownList>
                                         <asp:TextBox ID="txtEducacion" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
                                    </div>

                                </div>

                                

                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label ID="Label4" runat="server" Text="Grado"></asp:Label>
                                        <asp:DropDownList ID="DpdGrado" runat="server" CssClass="form-control" AutoPostBack="True" Enabled="false" OnSelectedIndexChanged="DpdGrado_SelectedIndexChanged"></asp:DropDownList>
                                        <asp:TextBox ID="txtGrado" CssClass="form-control" runat="server" Visible="false"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="form-group">
                                        <asp:Label ID="Label2" runat="server" Text="Seción"></asp:Label>
                                        <asp:DropDownList ID="DpdSeccion" runat="server" CssClass="form-control" AutoPostBack="True" OnSelectedIndexChanged="DpdSeccion_SelectedIndexChanged" Enabled="false">
                                            <asp:ListItem Selected="True"></asp:ListItem>
                                            <asp:ListItem>A</asp:ListItem>
                                            <asp:ListItem>B</asp:ListItem>
                                            <asp:ListItem>C</asp:ListItem>
                                        </asp:DropDownList>
                                        <asp:TextBox ID="txtSeccion" CssClass="form-control" Visible="false" runat="server"></asp:TextBox>
                                    </div>
                                </div>
                               
                            </div>

                            <div class="row">
                                <div class="col-md-9">
                                     <div class="form-group">
                                <asp:Label ID="Label3" runat="server" Text="Nombre"></asp:Label>
                                <asp:TextBox ID="txtNombreAbreviado" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                            </div>
                                </div>
                                <div class="col-md-3">

                                    <div class="form-group">
                                        <asp:Label ID="Label6" runat="server" Text="H/C Diarias"></asp:Label>
                                        <asp:TextBox ID="txtHorasClase" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
                                    </div>
                                
                                </div>
                            </div>

                            <div class="form-group">
                                <asp:Label ID="Label5" runat="server" Text="Orientador"></asp:Label>
                                <asp:DropDownList ID="DpdOrientador" runat="server" CssClass="form-control"></asp:DropDownList>
                                
                            </div>

                        </div>

                    </div>
                    
                </div>
                <div class="panel-footer">
                    <div class="row">
                        <div class="col-md-3">

                        </div>
                        <div class="col-md-6">
                            
                                <asp:Button ID="BtnRegistrar" runat="server" Text="Registrar" CssClass="btn btn-primary" OnClick="BtnRegistrar_Click" />
                            <asp:Button ID="BtnBuscar" visible="false" runat="server" Text="Buscar" CssClass="btn btn-primary" OnClick="BtnBuscar_Click"/>    
                            <asp:Button ID="BtnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-danger" OnClick="Button4_Click" />
                                 
                            
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

            <asp:Button ID="BtnGRegistrados" runat="server" Text="Grados Registrados" OnClick="BtnGRegistrados_Click" CssClass="btn-block btn btn-primary" />
            <asp:Button ID="BtnEditarG" runat="server" Text="Editar grado" CssClass="btn btn-primary btn-block" OnClick="BtnEditarG_Click"/>
            <asp:Button ID="BtnGRegistrar" runat="server" Text="Registrar grado" OnClick="BtnGRegistrar_Click" CssClass="btn-block btn btn-primary"/>
            
        </div>

    </div>

</asp:Content>
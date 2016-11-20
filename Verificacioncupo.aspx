<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Verificacioncupo.aspx.cs" Inherits="Verificacioncupo" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    
      <h3>Seleccione una sección:</h3>
    <asp:DropDownList ID="DropDownList1" cssclass="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
        <asp:ListItem>--Lista de secciones--</asp:ListItem>
      </asp:DropDownList>
    <div class="col-md-10 col-md-offset-5">
    <asp:Button ID="BtnCancelarCupo" cssclass="btn btn-lg" class="btn btn-default" runat="server" Text="Cancelar" />
    <asp:Button ID="BtnSigCupo"   class="btn btn-primary btn-lg" runat="server" Text="Siguiente" Enabled="False" OnClick="BtnSigCupo_Click"/>
    </div>
        <br />
    <br />
</asp:Content>


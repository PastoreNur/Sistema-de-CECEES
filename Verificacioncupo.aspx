<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Verificacioncupo.aspx.cs" Inherits="Verificacioncupo" %>



<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    

      <h3>Seleccione una sección:</h3>
    <asp:DropDownList ID="DropDownList1" cssclass="form-control" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="True">
      </asp:DropDownList>
    <div class="col-md-10 col-md-offset-5">
    <asp:Button ID="BtnCancelarCupo" cssclass="btn btn-lg" class="btn btn-default" runat="server" Text="Cancelar" />
    <asp:Label ID="BtnSigCupo"   class="btn btn-primary btn-lg"  runat="server" data-toggle="modal" data-target="#myModal" Text="Siguiente" Enabled="False" OnClick="BtnSigCupo_Click"/>
    </div>
    <br />
    <br />
   

<!-- Modal -->
<div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
  <div class="modal-dialog" role="document">
    <div class="modal-content">
      <div class="modal-header">
        <button type="button" class="close" data-dismiss="modal" aria-label="Close"><span aria-hidden="true">&times;</span></button>
        <h4 class="modal-title" id="myModalLabel">Verificando cupo</h4>
      </div>
      <div class="modal-body">
          <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-default" data-dismiss="modal">Atras</button>
          <asp:Button ID="BtnContinuar" class="btn btn-primary" runat="server" Enabled="false" Text="Continuar" OnClick="BtnContinuar_Click" />
      </div>
    </div>
  </div>
</div>

        <br />
    <br />
</asp:Content>


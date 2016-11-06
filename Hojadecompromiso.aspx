<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.master" AutoEventWireup="true" CodeFile="Hojadecompromiso.aspx.cs" Inherits="Hojadecompromiso" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h3>
        El reglamento interno de esta lnstitución Educativa, que conlleva, entre otros:

    </h3>
    <p>
1. Participar y Colaborar con las actividades académicas, culturales, sociales, religiosas, financieras, ecológicas,\n
deportivas y de otra indole que la institución realice.
</p>
<p>
2. Proveer a mi hijo/a de los recursos necesarios para las clases y trabajos exaula.
</p>
<p>3.Acudir a las reuniones progrÍunadas por la Dirección,subdirección,coordinación u Orientadordegradol'escuela
de padres según horario establecido.
</p>
<p>
4. Estar pendiente de la asistencia, adelanto conductual y académico de mi hijo/a en horario establecido por la
coordinación o maestro orientador (No en horas de clases).
</p>
    <p>
5. Responder por cualquier anomalia que mi hijo ocasione en perjuicio de los bienes de la institución o persona.
</p>
<p>
6. Si p¡ofeso otra religión, respetaré la formación y actividades religiosas que se realicen sabiendo que esta e§ una
institución católica.
</p>
    <p>
    7. No permitiré que mi hijo/V porte celular en la institución ni otros distractores aceptando que si lo porta le sea
decomisado y regresado hasta fin de año.
</p>
<p>
8. Una vez matriculadola ellla alumnala no pediré ninguna devolución.
</p>
<p>
9. No aprobaré noviazgo de mi hijo/a dentro ds la institución, ni fuera, portando el uniforme.
</p>
<p>
10. Pediré a mi hi.joia respeto al uniforme fuera de la institución evitando actos indecorosos. </p>
<p>
11. Aceptaré que mi hijo/a no podrá continuar en la institución después de acumular tres actas por faltas graves.
</p>
<p>
12. Ayudaré a mi hijo/a para que sus calificaciones sean mayores de seis, y al finalizar el año aceptaré que no será
matriculado si es menor.
</p>
    <p>
13. Si mi hjo/a olvida la tarea u otro implemento necesario paralaclase, no apoyaré esa falta de responsabilidad trayéndosela.
       </p>
     <p>
14. Exigiré a mi hijo/a la portación del uniforme según horario establecido y sin hacerle cambios.    
</p>
        <p>
        15. Aceptaré que mi hijo/a sea devuelto a casa si se presenta después de la hora establecida o mal uniformado; también
que no se retire de la institución sin permiso antes de haber concluido la jornada de clase.
</p>
        <p>
16. Aceptaré que mi hijo/a sea retirado de la institución si se le comprueba el consumo o distribución de sustancias
alucinógenas (alcohol, droga etc.)
</p>
        <p>
17. Justificaré por escrito toda inasistencia de mi hijo/a al centro educativo.
</p>
    <p>    
18. Cancelaré 12 cuotas mensuales según ciclo o nivel antes del 26 de cada mes, sabiendo que el mes de noviembre se
cancelará en junio y el mes de diciembre, en octubre, procurando estar
solvente antes de las evaluaciones trimestrales o de periodos.
        </p>
    <p>
19.Garantizare que mi hijo porte mochila transparente.
</p>
    <h3>
        Leído lo anterior y dando fe, firmo la presente.
    </h3>
    <p>(Marcar la casilla para seguir con la matricula, firmar antes de hoja de compromiso con el encargado de la matricula)</p>
    <asp:CheckBox ID="ChcBCompromiso" Text="Si, estoy de acuerdo" runat="server" Checked ="false" OnCheckedChanged="ChcBCompromiso_CheckedChanged" AutoPostBack="True" />
    <asp:Button ID="BtnCancelarCompromiso" runat="server" Text="Cancelar" />
    <asp:Button ID="BtnSigcompromiso" runat="server" Text="Siguiente" CausesValidation="False" Enabled="False" EnableTheming="True" Visible="true" />
</asp:Content>


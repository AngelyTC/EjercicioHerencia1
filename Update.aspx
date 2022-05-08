<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EjercicioHerencia1.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<span style="font-size: xx-large">Actualizar</span><p>
        Ingrese el No.Igss</p>
<p>
    <asp:TextBox ID="txtIngrIgss" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Personal" OnClick="btnBuscar_Click" />
</p>
<p>
    Nombre</p>
<p>
    <asp:TextBox ID="txtNombree" runat="server"></asp:TextBox>
</p>
<p>
    Apellido</p>
<p>
    <asp:TextBox ID="txtApellidos" runat="server"></asp:TextBox>
</p>
    <p>
        Direccion</p>
    <p>
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
</p>
    <p>
        Profesion</p>
    <p>
        <asp:TextBox ID="txtProfesionU" runat="server"></asp:TextBox>
</p>
    <p>
        Fecha Inicio</p>
    <p>
        <asp:Calendar ID="CalendarIn" runat="server"></asp:Calendar>
</p>
    <p>
        Fecha Fin</p>
    <p>
        <asp:Calendar ID="CalendarF" runat="server"></asp:Calendar>
</p>
<p>
    <asp:Button ID="btnModificar" runat="server" Text="Modificar Datos" OnClick="btnModificar_Click" />
</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>

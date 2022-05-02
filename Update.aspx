<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Update.aspx.cs" Inherits="EjercicioHerencia1.Update" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <br />
<span style="font-size: xx-large">Actualizar</span><p>
    Ingrese el carné</p>
<p>
    <asp:TextBox ID="txtIngrCarne" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnBuscar" runat="server" Text="Buscar Alumno" OnClick="btnBuscar_Click" />
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
    <asp:Button ID="btnModificar" runat="server" Text="Modificar Datos" />
</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
    &nbsp;</p>
<p>
</p>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Delete.aspx.cs" Inherits="EjercicioHerencia1.Delete" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
    <br />
    <span style="font-size: x-large">Eliminar</span></p>
<p>
    Carné</p>
<p>
    <asp:TextBox ID="txtCarneb" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnBuscarAl" runat="server" Text="Buscar Alumno" OnClick="btnBuscarAl_Click" />
</p>
<p>
    Nombre</p>
<p>
    <asp:TextBox ID="txtNombres" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    Apellidos</p>
<p>
    <asp:TextBox ID="txtApellido" runat="server" Enabled="False"></asp:TextBox>
</p>
<p>
    <asp:Button ID="btnBorrar" runat="server" Text="Borrar Datos" OnClick="btnBorrar_Click" />
</p>
<p>
</p>
</asp:Content>

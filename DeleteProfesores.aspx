<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DeleteProfesores.aspx.cs" Inherits="EjercicioHerencia1.DeleteProfesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        &nbsp;</p>
<p style="font-size: x-large">
        INGRESO PROFESORES</p>
<p>
        <br />
        <asp:Label ID="Label1" runat="server" Text="ID Profesor"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtIdP" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnBuscarP" runat="server" OnClick="btnBuscarP_Click" Text="Buscar ID" />
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Nombre"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtNombrePro" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Apellidos"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtApellidoPro" runat="server"></asp:TextBox>
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Modificar  Datos" />
    </p>
    <p>
    </p>
</asp:Content>

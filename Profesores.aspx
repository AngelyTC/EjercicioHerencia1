<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profesores.aspx.cs" Inherits="EjercicioHerencia1.Profesores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br style="font-size: large" />
        <span style="font-size: large">INGRESO PROFESORES</span></p>
    <p>
        <asp:Label ID="Label5" runat="server" Text="Id Profesor"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Text="Nombre"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtNombreP" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Apellidos"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtApellidoP" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" Text="Direccion"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtDireccionP" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" Text="Fecha Nacimiento"></asp:Label>
    </p>
    <p>
        <asp:Calendar ID="Calendar1" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" Text="Titulo"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtTitulo" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" Text="Cálculo de edad"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:Button ID="btnEdad" runat="server" OnClick="btnEdad_Click" Text="Ver edad" Width="123px" />
    </p>
    <p>
        <asp:Button ID="btnIngreso" runat="server" Height="45px" OnClick="btnIngreso_Click" Text="Ingresar" Width="103px" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

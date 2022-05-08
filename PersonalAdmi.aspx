<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PersonalAdmi.aspx.cs" Inherits="EjercicioHerencia1.PersonalAdmi" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <p>
        <br />
        Ingreso Personal Administrativo</p>
    <p>
        <asp:Label ID="Label1" runat="server" style="font-size: small" Text="No.IGSS"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtIGSS" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label5" runat="server" style="font-size: small" Text="Nombre"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtNombreA" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label6" runat="server" style="font-size: small" Text="Apellido"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtApellidoA" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label7" runat="server" style="font-size: small" Text="Direccion"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtDireccionA" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label2" runat="server" style="font-size: small" Text="Profesion"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtProfesion" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Label ID="Label3" runat="server" style="font-size: small" Text="Fecha Inicio"></asp:Label>
    </p>
    <p>
        <asp:Calendar ID="CalendarInicio" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label4" runat="server" style="font-size: small" Text="Fecha Fin"></asp:Label>
    </p>
    <p>
        <asp:Calendar ID="CalendarFin" runat="server"></asp:Calendar>
    </p>
    <p style="font-size: small">
        Fecha Nacimiento</p>
    <p>
        <asp:Calendar ID="CalendarFechaN" runat="server"></asp:Calendar>
    </p>
    <p>
        <asp:Label ID="Label8" runat="server" style="font-size: small" Text="Edad Personal"></asp:Label>
    </p>
    <p>
        <asp:TextBox ID="txtEdadP" runat="server"></asp:TextBox>
        <asp:Button ID="btnEdadP" runat="server" OnClick="btnEdadP_Click" Text="Ver edad" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        <asp:Button ID="btnIngresarA" runat="server" OnClick="btnIngresarA_Click" Text="Ingresar Datos" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>

<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="EjercicioHerencia1.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <address>
        &nbsp;</address>
    <address>
        INGRESOS UNIVERSIDAD</address>
    <address>
        <asp:Label ID="Label1" runat="server" Text="Nombre Universidad"></asp:Label>
        <asp:TextBox ID="txtUni" runat="server"></asp:TextBox>
    </address>
    <address>
        <asp:Label ID="Label2" runat="server" Text="Alumnos"></asp:Label>
        <asp:TextBox ID="txtAlumno" runat="server"></asp:TextBox>
    </address>
    <address>
        <asp:Label ID="Label3" runat="server" Text="Nota"></asp:Label>
        <asp:TextBox ID="txtNota" runat="server"></asp:TextBox>
    </address>
    <address>
        <asp:Label ID="Label4" runat="server" Text="Nombre de curso"></asp:Label>
        <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
    </address>
    <address>
        <asp:Button ID="btnIngresar" runat="server" OnClick="btnIngresar_Click" Text="Ingresar" />
    </address>
    <address>
        &nbsp;</address>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="EjercicioHerencia1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron">
        <h1>ASP.NET</h1>
        <p class="lead">ASP.NET is a free web framework for building great Web sites and Web applications using HTML, CSS, and JavaScript.</p>
        <p><a href="http://www.asp.net" class="btn btn-primary btn-lg">Learn more &raquo;</a></p>
        <asp:Label ID="Label1" runat="server" Text="INGRESO DATOS"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        No Carne<br />
        <asp:TextBox ID="txtCarne" runat="server"></asp:TextBox>
        &nbsp;<br />
        Nombre<br />
        <asp:TextBox ID="txtNombre" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        <br />
        Apellido<br />
        <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="c" runat="server" Text="Curso"></asp:Label>
        <br />
        <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
        <br />
        Notas<br />
        <asp:TextBox ID="txtNotas" runat="server"></asp:TextBox>
        <asp:Button ID="btnNotas" runat="server" OnClick="btnNotas_Click" Text="Ingreso Notas" />
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <br />
        Direccion<br />
        <asp:TextBox ID="txtDireccion" runat="server"></asp:TextBox>
        <br />
        Fecha Nacimiento<br />
        <asp:Calendar ID="txtFecha" runat="server"></asp:Calendar>
        <br />
        Edad<br />
        <asp:TextBox ID="txtEdad" runat="server"></asp:TextBox>
        <asp:Button ID="btnEdadA" runat="server" Text="Ver edad del Alumno" OnClick="btnEdadA_Click" />
        <br />
        <br />
        I<asp:Button ID="btnIngreso" runat="server" Text="Ingresar" OnClick="btnIngreso_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Universidad"></asp:Label>
        <br />
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem>mesoamericana</asp:ListItem>
            <asp:ListItem>Landivar</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Ingreso para universidades" />
        <br />
    </div>

</asp:Content>

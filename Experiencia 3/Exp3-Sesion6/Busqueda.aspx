<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Busqueda.aspx.cs" Inherits="Exp3_Sesion6.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <style type="text/css">
        .nuevoEstilo1 {
            background-image: url('Fondo.png');
            height: 1064px;
        }
    </style>

</head>
<body class="style1">
    <form id="form1" runat="server">
            <div class="nuevoEstilo1">
            <asp:Label ID="Label1" runat="server" BackColor="Black" ForeColor="Yellow" Text="Búsqueda de CLIENTES" CssClass="style2" Font-Size="XX-Large"></asp:Label>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Código"></asp:Label>
            <asp:TextBox ID="txtCodigo" runat="server"></asp:TextBox>
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
            <asp:Button ID="btnLimpiar" runat="server" OnClick="btnLimpiar_Click" Text="Limpiar" />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Nombres"></asp:Label>
            <asp:TextBox ID="txtNombres" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Dirección"></asp:Label>
            <asp:TextBox ID="txtDireccion" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label5" runat="server" Text="Teléfono"></asp:Label>
            <asp:TextBox ID="txtTelefono" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label6" runat="server" Text="E-Mail"></asp:Label>
            <asp:TextBox ID="txtMail" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Label ID="Label7" runat="server" Text="Edad"></asp:Label>
            <asp:TextBox ID="txtEdad" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar Todos los Clientes" />
            <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
            <br />
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </div>
    </form>
</body>
</html>

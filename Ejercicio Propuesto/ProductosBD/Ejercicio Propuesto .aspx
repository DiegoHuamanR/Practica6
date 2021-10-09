<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio Propuesto 3.aspx.cs" Inherits="PRACTICA_6.Ejercicio_Propuesto_3" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 352px;
            height: 113px;
            font-size: 32pt;
            margin-left: 257px;
            justify-content: center;
            align-items: center;
            color: #000000;
            background-color: #3399FF;
        }
        .auto-style2 {}
        .auto-style3 {
            background-color: #FFFF99;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style3">
            <br />
            <div  class="auto-style1"> 
                BUSQUEDA DE PRODUCTOS</div>
            <br />
            Codigo&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtCodigo" runat="server" CssClass="auto-style2" Width="53px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnBuscar" runat="server" OnClick="btnBuscar_Click" Text="Buscar" />
&nbsp;
            <asp:Button ID="butnLimpiar" runat="server" OnClick="butnLimpiar_Click" Text="Limpiar" />
            <br />
            <br />
            Nombre&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:TextBox ID="txtNombres" runat="server"></asp:TextBox>
            <br />
            Precio&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtPrecio" runat="server"></asp:TextBox>
            <br />
            Stock&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtStock" runat="server"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnMostrar" runat="server" OnClick="btnMostrar_Click" Text="Mostrar todos los Productos" />
            <br />
            <br />
            <asp:GridView ID="GridView1" runat="server" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black">
                <FooterStyle BackColor="#CCCCCC" />
                <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Left" />
                <RowStyle BackColor="White" />
                <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F1F1F1" />
                <SortedAscendingHeaderStyle BackColor="#808080" />
                <SortedDescendingCellStyle BackColor="#CAC9C9" />
                <SortedDescendingHeaderStyle BackColor="#383838" />
            </asp:GridView>
            <br />
            <asp:Label ID="lblResult" runat="server" Text="Label"></asp:Label>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>

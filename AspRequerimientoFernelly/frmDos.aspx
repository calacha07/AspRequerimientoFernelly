<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmDos.aspx.cs" Inherits="AspRequerimientoFernelly.frmDos" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        
        <center>

                <asp:GridView ID="GridProducto" runat="server"></asp:GridView>
                <asp:DropDownList ID="lstCategoria" runat="server"></asp:DropDownList> <br />
               <asp:Button ID="btnCargarTodo" runat="server" Text="Cargar" OnClick="btnCargarTodo_Click"></asp:Button> <br />
                <asp:Button ID="Button1" runat="server" Text="Ir a Index" OnClick="Button1_Click"></asp:Button>



        </center>
    </form>
</body>
</html>

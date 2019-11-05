<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTres.aspx.cs" Inherits="AspRequerimientoFernelly.frmTres" %>

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
                <asp:DropDownList ID="lstCategoria" runat="server" OnSelectedIndexChanged="lstCategoria_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList> <br />
               <asp:Button ID="Button1" runat="server" Text="Ir a Index" OnClick="Button1_Click" style="height: 26px"></asp:Button>


        </center>
    </form>
</body>
</html>

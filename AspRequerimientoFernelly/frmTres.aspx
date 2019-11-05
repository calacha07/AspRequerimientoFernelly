<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="frmTres.aspx.cs" Inherits="AspRequerimientoFernelly.frmTres" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
               
        <center>
            
                <h1>CARGA DE PRODUCTOS POR CATEGORÍA </h1>
                <asp:GridView ID="GridProducto" runat="server" CssClass="table  table-hover"></asp:GridView>
                <asp:DropDownList ID="lstCategoria" runat="server" OnSelectedIndexChanged="lstCategoria_SelectedIndexChanged" CssClass="mt-2" AutoPostBack="true"></asp:DropDownList> <br />
               <asp:Button ID="Button1" runat="server" Text="Ir a Index" OnClick="Button1_Click" CssClass="btn btn-info mt-2"></asp:Button>


        </center>
    </form>
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
</body>
</html>

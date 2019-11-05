<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="AspRequerimientoFernelly.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous">
</head>
<body>
    <form id="form1" runat="server">
        <div class="mt-3 d-flex align-content-center justify-content-center align-items-center">
            <ul class="nav nav-tabs" id="navId">
 
            

    <li class="nav-item mr-2">
           <asp:Button ID="Button2" runat="server" Text="Segundo Form" OnClick="Button2_Click"  CssClass="btn btn-info"/>
    </li>
    <li class="nav-item">
          <asp:Button ID="Button3" runat="server" Text="TercerForm" OnClick="Button3_Click" CssClass="btn btn-info" />
    </li>

          <li class="nav-item ml-2">
          <asp:Button ID="Button4" runat="server" Text="CuartoForm" OnClick="Button4_Click" CssClass="btn btn-info"  />
    </li>
</ul>

<!-- Tab panes -->
<div class="tab-content">
    <div class="tab-pane fade show active" id="tab1Id" role="tabpanel"></div>
    <div class="tab-pane fade" id="tab2Id" role="tabpanel"></div>
    <div class="tab-pane fade" id="tab3Id" role="tabpanel"></div>
    <div class="tab-pane fade" id="tab4Id" role="tabpanel"></div>
    <div class="tab-pane fade" id="tab5Id" role="tabpanel"></div>
</div>

<script>
    $('#navId a').click(e => {
        e.preventDefault();
        $(this).tab('show');
    });
</script>
    
        </div>


        <center>

                <h1>CARGA CON XML</h1>
                <asp:GridView ID="GridProducto" runat="server" CssClass="table  table-hover"></asp:GridView>
                <asp:DropDownList ID="lstCategoria" runat="server" CssClass="mt-2"></asp:DropDownList> <br />
               <asp:Button ID="btnCargarTodo" runat="server" Text="Cargar" OnClick="btnCargarTodo_Click" CssClass="btn btn-info mt-2"></asp:Button>
     






        </center>


    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
<script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>
        
             

        
    </form>


    </body>
</html>

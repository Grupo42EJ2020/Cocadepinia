<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ObtenerEmpleados</title>
     <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
    background: #FFFFE0;
    font-family: Cooper Black; 
    }
    a:link, a:visited{
    text-decoration: none;
    padding: 10px;
    font-family: Cooper Black;
    text-transform: uppercase;
    padding-left: 5px;
    padding-right:5px;
    font-weight: 20;
    font-size: 11px;
    color: black;
    width:100px;
    height:12px;
    text-align:center;
    display: inline-block;
    margin: 10px 10px 0 10px;
    background-color: #FFE4C4;
    }
    a:hover{
    color: #4c5557;
    background-color: #FFA07A;
    text-decoration: none;
    }           
    
    </style>
</head>
<body>
<center>
    <table>
        <tr>
            <th></th>
            <th>
                IdEmpleado
            </th>
            <th>
                Nombre
            </th>          
            
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "EmpleadoEdit", new {  id=item.IdEmpleado  }) %> |
                <%: Html.ActionLink("Detalles", "EmpleadoDetails", new {  id=item.IdEmpleado})%> |
                <%: Html.ActionLink("Borrar", "EmpleadoDelete", new {  id=item.IdEmpleado  })%>
            </td>
            <td>
                <%: item.IdEmpleado%>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
           
            
        </tr>
    
    <% } %>

    </table>
    
    <p>
        <%: Html.ActionLink("Nuevo Empleado", "EmpleadoCreate")%>  <a href ="/Empleados/Index">Regresar</a>
    </p>
    
    <img src="../../Content/empleadover.jpg" />
    </center>

</body>
</html>


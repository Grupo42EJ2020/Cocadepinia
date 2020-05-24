<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Empleado>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>ObtenerEmpleados</title>
</head>
<body>
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
        <%: Html.ActionLink("Registrar Nuevo Empleado", "Index")%>
    </p>

</body>
</html>


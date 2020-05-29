<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Cursos>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
<body background=" ../../Content/cocapinia2.jpg" />
    
    <table border="1" align="center" bordercolor="red" cellspacing="0">
    <caption style="color:red">DATOS</caption>
        <tr>
            <th></th>
            
            <th width="200" bgcolor="yellow">Id Cursos</th>
            <th width="200" bgcolor="yellow">Descripción</th>
            <th width="200" bgcolor="yellow">Id del empleado</th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td height="50" width="150"  bgcolor="yellow">
                <%: Html.ActionLink("Editar", "CursosEdit", new { id=item.IdCursos }) %> |
                <%: Html.ActionLink("Detalles", "CursosDetails", new { id=item.IdCursos })%> |
                <%: Html.ActionLink("Eliminar", "CursosDelete", new {id=item.IdCursos })%>
            </td>
            <td height="50" width="150"  bgcolor="yellow">
                <%: item.IdCursos %>
            </td>
            <td height="50" width="150"  bgcolor="yellow">
                <%: item.Descripcion %>
            </td>
            <td height="50" width="150"  bgcolor="yellow">
                <%: item.IdEmpleado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <table border="1" align="center" bordercolor="red" cellspacing="0">
    <td height="50" width="150"  bgcolor="yellow">
    <p>
<%: Html.ActionLink("Crear Curso", "CursosCreate") %>
<br />
<a href="/Home/index">Regresar al menú</a>
    </p>
</td>
</table>
</body>
</html>


<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<IEnumerable<MVCLaboratorio.Models.Cursos>>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Index</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCursos
            </th>
            <th>
                Descripcion
            </th>
            <th>
                IdEmpleado
            </th>
        </tr>

    <% foreach (var item in Model) { %>
    
        <tr>
            <td>
                <%: Html.ActionLink("Edit", "CursosEdit", new { id=item.IdCursos }) %> |
                <%: Html.ActionLink("Details", "CursosDetails", new { id=item.IdCursos })%> |
                <%: Html.ActionLink("Delete", "CursosDelete", new {id=item.IdCursos })%>
            </td>
            <td>
                <%: item.IdCursos %>
            </td>
            <td>
                <%: item.Descripcion %>
            </td>
            <td>
                <%: item.IdEmpleado %>
            </td>
        </tr>
    
    <% } %>

    </table>

    <p>
        <%: Html.ActionLink("Create New", "CursosCreate") %>
    </p>

</body>
</html>


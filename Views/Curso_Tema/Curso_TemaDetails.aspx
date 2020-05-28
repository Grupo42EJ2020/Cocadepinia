<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Detalles de Curso_Tema</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdCT
            </th>
            <th>
                IdCurso
            </th>
            <th>
                IdTema
            </th>              
        </tr>
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "Curso_TemaEdit", new {  id=item.IdCT  }) %> |
                <%: Html.ActionLink("Detalles", "Curso_TemaDetail", new {  id=item.IdCT  })%> |
                <%: Html.ActionLink("Borrar", "Curso_TemaDelete", new {  id=item.IdCT  })%>
            </td>
            <td>
                <%: item.IdCT %>
            </td>
            <td>
                <%: item.IdCurso %>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
        </tr>
    <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Nuevo Curso_Tema", "Curso_TemaCreate")%>
        <a href="/Curso_Tema/Index">Regresar al menu de Curso tema</a>
    </p>
</body>
</html>

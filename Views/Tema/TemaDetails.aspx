<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Detalles de Tema</title>
</head>
<body>
    <table>
        <tr>
            <th></th>
            <th>
                IdTema
            </th>
            <th>
                Nombre
            </th>            
        </tr>
    <% foreach (var item in Model) { %>
        <tr>
            <td>
                <%: Html.ActionLink("Editar", "TemaEdit", new {  id=item.IdCT  }) %> |
                <%: Html.ActionLink("Detalles", "TemaDetail", new {  id=item.IdCT  })%> |
                <%: Html.ActionLink("Borrar", "TemaDelete", new {  id=item.IdCT  })%>
            </td>
            <td>
                <%: item.IdTema %>
            </td>
            <td>
                <%: item.Nombre %>
            </td>
        </tr>
    <% } %>
    </table>
    <p>
        <%: Html.ActionLink("Nuevo Tema", "TemaCreate")%>
    </p>
</body>
</html>
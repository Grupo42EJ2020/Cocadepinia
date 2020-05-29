<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Cursos>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>CursosDetails</title>
</head>
<body background="../../Content/coca.png" />
    
<fieldset>
    
        <legend>Datos</legend>
        
        <div class="display-label">IdCursos</div>
        <div class="display-field"><%: Model.IdCursos %></div>
        
        <div class="display-label">Descripcion</div>
        <div class="display-field"><%: Model.Descripcion %></div>
        
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
    </fieldset>
    <p>
        <%: Html.ActionLink("Editar", "CursosEdit", new { id=Model.IdCursos }) %> |
        <%: Html.ActionLink("Regresar", "Index") %>
    </p>

</body>
</html>


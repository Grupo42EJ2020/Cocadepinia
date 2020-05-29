<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Borrar un Empleado</title>
     <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
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
    font-size: 10px;
    color: white;
    width:100px;
    height:12px;
    text-align:center;
    display: inline-block;
    margin: 10px 10px 0 10px;
    background-color: #DC143C;
    }
    a:hover{
    color: #4c5557;
    background-color: #FF6347;
    text-decoration: none;
    }           
    
    </style>
</head>
<body background="../../Content/empleadodelete.jpg" />
<img src="../../Content/mensaje.png" />
<center>
    <h3>¿Esta seguro de eliminar la siguiente información?</h3>
    <fieldset>
        <legend>Datos del Empleado</legend>
        
        <div class="display-label">IdEmpleado</div>
        <div class="display-field"><%: Model.IdEmpleado %></div>
        
        <div class="display-label">Nombre</div>
        <div class="display-field"><%: Model.Nombre %></div>
        
        <div class="display-label">Url</div>
        <div class="display-field"><%: Model.Direccion %></div>
        
    </fieldset>
    <% using (Html.BeginForm()) { %>
        <p>
		    <input type="submit" value="Borrar" /> |
		    <%: Html.ActionLink("Regresar a lista", "EmpleadosVer") %>
        </p>
    <% } %>
    </center>
</body>
</html>


<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head id="Head1" runat="server">
    <title>Actualización datos del Empleado</title>
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
    background-color: #ADD8E6;
    }
    a:hover{
    color: #4c5557;
    background-color: #B8860B;
    text-decoration: none;
    }           
    
    </style>
</head>
<body background="../../Content/empleadosedit.png" />
<center>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>
        
        <fieldset>
            <legend>Datos</legend>
                                   
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Nombre) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Nombre) %>
                <%: Html.ValidationMessageFor(model => model.Nombre) %>
            </div>
            
            <div class="editor-label">
                <%: Html.LabelFor(model => model.Direccion) %>
            </div>
            <div class="editor-field">
                <%: Html.TextBoxFor(model => model.Direccion) %>
                <%: Html.ValidationMessageFor(model => model.Direccion) %>
            </div>
            
            <p>
                <input type="submit" value="Guardar" />
            </p>
        </fieldset>

    <% } %>

    <div>
        <%: Html.ActionLink("Regresar a lista", "EmpleadosVer") %>
    </div>
    
    </center>
</body>
</html>

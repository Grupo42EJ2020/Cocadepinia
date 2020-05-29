<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<MVCLaboratorio.Models.Empleado>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Registrar Nuevo Empleado</title>
      <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
    background: #FFFFFF;
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
    background-color: #87CEEB ;
    }
    a:hover{
    color: #4c5557;
    background-color: #4682B4;
    text-decoration: none;
    }           
    
    </style>
</head>
<body>
<center>
    <% using (Html.BeginForm()) {%>
        <%: Html.ValidationSummary(true) %>

        <fieldset>
            <legend>Fields</legend>
            
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
                <input type="submit" value="Create" />
            </p>
        </fieldset>

    <% } %>

    <div>
<<<<<<< HEAD
        <%: Html.ActionLink("Regresar a lista", "EmpleadosVer") %>
=======
        <%: Html.ActionLink("Regresar a la lista", "TemaVer") %>
>>>>>>> 307becf304c59a187a20a30fedf8024d5b5ebd4f
    </div>
    <img src="../../Content/registrar%20empleado.jpg" />
    </center>
</body>
</html>


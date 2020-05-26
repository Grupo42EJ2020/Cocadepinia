<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Empleados</title>
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
    <h1>BIENVENIDO TABLA EMPLEADOS</h1>
    <a href ="/Empleados/EmpleadosVer">lista Empleados</a>
    <br />
    <a href="/Home/Index">Regresar a Menu</a>
    
    <img src="../../Content/Empleados.png" />
    </center>
    
</body>
</html>

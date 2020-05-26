<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Pia Desarrollo de Software</title>
     <style type="text/css">
    html, body
    {
    width: 100%;
    height: 110%; 
    font-family: LCD ; 
    }
    a:link, a:visited{
    text-decoration: none;
    font-family: LCD ;
    text-transform: uppercase;
    padding-left: 10px;
    padding-right: 10px;
    font-weight: 100;
    font-size: 15px;
    color: white;
    width:200px;
    height:25px;
    text-align:center;
    display: inline-block;
    margin: 20px 20px 0 20px;
    background-color: #000000;
    }
    a:hover{
    color: #4c5557;
    background-color: #DC143C;
    text-decoration: none;
    }           
    
    </style>
</head>
<body background="../../Content/coca.png" />
    <center>

   
   <font size=7>Bienvenidos al PIA de Coca de Piña 👍</font> 
   <h1>
    MENU

    </h1>
    <br />
    

    <a href="/Empleados/Index">Empleados</a>
    <br />
<a href="/Cursos/Index">Datos de los Cursos</a>
<br />
<a href="/Cursos/Index">Videos sobre los temas de los cursos</a>

<br />
<a href="/Curso_Tema/Index">Datos de los Temas de Cursos</a>
<br />
<img src="../../Content/cocapinia.jpeg" />
</center>
</body>
</html>

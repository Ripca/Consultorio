
<%@page import="logica.Usuario"%>
<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%@include file="components/header.jsp"%>   
<%@include file="components/bodyprimeraparte.jsp"%>
<h1>Editar Usuarios</h1>

<%Usuario usu = (Usuario) request.getSession().getAttribute("usuEditar");%>


<form class="user" action="SvEditUsuarios" method="POST">
    <div class="form-group col">
        <div class="col-sm-6 mb-3">
<!--    poner las comillas si da error-->
            <input type="text" class="form-control form-control-user" id="nombreusu" name="nombreusu"
                       placeholder="Nombre Usuario" value="<%=usu.getNombreUsuario()%>">
        </div>
        <div class="col-sm-6 mb-3">
            <input type="text" class="form-control form-control-user" id="contrasenia" name="contrasenia"
                   placeholder="Contraseña" value="<%=usu.getContrasenia()%>"  
               
                   >
        </div>

        <div class="col-sm-6 mb-3">
            <input type="text" class="form-control form-control-user" id="rol" name="rol"
                   placeholder="Rol" value="<%=usu.getRol()%>">
        </div>


    </div>
    <button type="submit" class="btn btn-primary btn-user btn-block">
        Guardar Modificacion
    </button>

</form>

<%@include file="components/bodyfinal.jsp"%>

<%@page contentType="text/html" pageEncoding="UTF-8"%>

<%@include file="components/header.jsp"%>   
<%@include file="components/bodyprimeraparte.jsp"%>
<h1 style=" text-align:center" >Alta Usuarios</h1>

<form class="user" action="SvUsuarios" method="POST">
    <div class="form-group col">
        <div class="col-sm-6 mb-3" style="margin-left: auto; margin-right: auto">
            <input type="text" class="form-control form-control-user" id="nombreusu" name="nombreusu"
                   placeholder="Nombre Usuario">
        </div>
        <div class="col-sm-6 mb-3" style="margin-left: auto; margin-right: auto">
            <input type="password" class="form-control form-control-user" id="contrasenia" name="contrasenia"
                   placeholder="Contraseña">
        </div>

        <div class="col-sm-6 mb-3" style="margin-left: auto; margin-right: auto">
            <input type="text" class="form-control form-control-user" id="rol" name="rol"
                   placeholder="Rol">
        </div>
                   
        </div>
        <button type="submit" class="btn btn-primary btn-user btn-block" style="width:45% ;margin-left: auto; margin-right: auto">
            Crear Usuario
        </button>

</form>

<%@include file="components/bodyfinal.jsp"%>
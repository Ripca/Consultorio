
<%@page contentType="text/html" pageEncoding="UTF-8"%>
<body id="page-top">

<!-- Validacion de la sesion -->
    <%HttpSession misesion=request.getSession();
        String usuario=(String) request.getSession().getAttribute("usuario");
        
        if (usuario==null) {
                response.sendRedirect("sinLogin.jsp");
            }

    %>  
    
        <!-- Page Wrapper -->
        <div id="wrapper">

            <!-- Sidebar -->
            <ul class="navbar-nav bg-gradient-primary sidebar sidebar-dark accordion" id="accordionSidebar">

                <!-- Sidebar - Brand -->
                <a class="sidebar-brand d-flex align-items-center justify-content-center" href="index.jsp">
                    <div class="sidebar-brand-icon rotate-n-15">
                        <i class="fas fa-solid fa-tooth"></i>                </div>
                    <div class="sidebar-brand-text mx-3">Consultorio</div>
                </a>

                
                <!-- Divider -->
                <hr class="sidebar-divider my-0">

                <!-- Nav Item - Dashboard -->
                <li class="nav-item active">
                    <a class="nav-link" >
                        <i class="fas fa-solid fa-bars"></i>
                        <span>Menu</span></a>
                </li>

                <!-- Divider -->
                <hr class="sidebar-divider">

                <!-- Heading -->
                <div class="sidebar-heading">
                    Gestion
                </div>

                <!-- Nav Item - Pages Collapse Menu -->
                <li class="nav-item">
                    <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseTwo"
                       aria-expanded="true" aria-controls="collapseTwo">
                        <i class="fas fa-hospital-user"></i>
                        <span>Odontologos</span>
                    </a>
                    <div id="collapseTwo" class="collapse" aria-labelledby="headingTwo" data-parent="#accordionSidebar">
                        <div class="bg-white py-2 collapse-inner rounded">
                            <h6 class="collapse-header">Acciones:</h6>
                            <a class="collapse-item" href="">Ver Odontologos</a>
                            <a class="collapse-item" href="altaOdontologo.jsp">Alta Odontologos</a>


                        </div>
                    </div>
                </li>

                <!-- Nav Item - Utilities Collapse Menu -->
                <li class="nav-item">
                    <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseUtilities"
                       aria-expanded="true" aria-controls="collapseUtilities">
                        <i class="fas fa-solid fa-bed"></i>
                        <span>Pacientes</span>
                    </a>
                    <div id="collapseUtilities" class="collapse" aria-labelledby="headingUtilities"
                         data-parent="#accordionSidebar">
                        <div class="bg-white py-2 collapse-inner rounded">
                            <h6 class="collapse-header">Acciones:</h6>
                            <a class="collapse-item" href="">Ver Pacientes</a>
                            <a class="collapse-item" href="">Alta Pacientes</a>                            
                        </div>
                    </div>

                                    <!-- Nav Item - Utilities Collapse Menu -->
                <li class="nav-item">
                    <a class="nav-link collapsed" href="#" data-toggle="collapse" data-target="#collapseUser"
                       aria-expanded="true" aria-controls="collapseUtilities">
                        <i class="fas fa-solid fa-bed"></i>
                        <span>Usuarios</span>
                    </a>
                    <div id="collapseUser" class="collapse" aria-labelledby="headingUtilities"
                         data-parent="#accordionSidebar">
                        <div class="bg-white py-2 collapse-inner rounded">
                            <h6 class="collapse-header">Acciones:</h6>
                            <a class="collapse-item" href="SvUsuarios">Ver Usuarios</a>
                            <a class="collapse-item" href="altaUsuario.jsp">Alta Usuarios</a>                            
                        </div>
                    </div>
                    
                    
                <!-- Divider -->
                <hr class="sidebar-divider d-none d-md-block">
            </ul>
            <!-- End of Sidebar -->

            <!-- Content Wrapper -->
            <div id="content-wrapper" class="d-flex flex-column">

                <!-- Main Content -->
                <div id="content">

                    <!-- Topbar -->
                    <nav class="navbar navbar-expand navbar-light bg-white topbar mb-4 static-top shadow">

                        <!-- Sidebar Toggle (Topbar) -->
                        <button id="sidebarToggleTop" class="btn btn-link d-md-none rounded-circle mr-3">
                            <i class="fa fa-bars"></i>
                        </button>

                        <!-- Topbar Search -->

                        <!-- Topbar Navbar -->
                        <ul class="navbar-nav ml-auto">

     
                            <!-- Nav Item - User Information -->
                            <li class="nav-item dropdown no-arrow">
                                <a class="nav-link dropdown-toggle" href="#" id="userDropdown" role="button"
                                   data-toggle="dropdown" aria-haspopup="true" aria-expanded="false">
                                    <span class="mr-2 d-none d-lg-inline text-gray-600 small"><%=request.getSession().getAttribute("usuario")%></span>
                                    <img class="img-profile rounded-circle"
                                         src="img/undraw_profile.svg">
                                </a>
                                <!-- Dropdown - User Information -->
                                <div class="dropdown-menu dropdown-menu-right shadow animated--grow-in"
                                     aria-labelledby="userDropdown">
                                    
                                    <a class="dropdown-item" href="#" data-toggle="modal" data-target="#logoutModal">
                                        <i class="fas fa-sign-out-alt fa-sm fa-fw mr-2 text-gray-400"></i>
                                        Cerrar Sesión
                                    </a>
                                </div>
                            </li>

                        </ul>

                    </nav>
                    <!-- End of Topbar -->

                    <!-- Begin Page Content -->
                    <div class="container-fluid">

                        <!-- Page Heading -->
                        <div class="d-sm-flex align-items-center justify-content-between mb-4">
                            <h1 class="h3 mb-0 text-gray-800">Clínica Odontológica</h1>
                          
                        </div>

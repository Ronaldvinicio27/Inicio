<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="perfil.aspx.cs" Inherits="LoginAspNet.perfil" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>
                Bienvenido <asp:Label ID="nombre_usuario" runat="server" />
            </h1>
            <p>Aqui esta la pagina de perfil que indica que ha iniciado sesión
                correctamente
            </p>
        </div>
    </form>
</body>
</html>

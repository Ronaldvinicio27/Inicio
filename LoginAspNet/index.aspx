<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="LoginAspNet.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
     <link href='https://fonts.googleapis.com/css?family=Montserrat' rel='stylesheet' type='text/css' />
    <link href="assets/css/main.css" rel="stylesheet" type="text/css" />
</head>
<body>
   
    <div class="login">
        <h2 class="active">Acceder </h2>

        <h2 class="nonactive">Registrar </h2>
        <form id="form1" runat="server">

            <asp:Label ID="errors" runat="server" CssClass="errors" />

            <asp:TextBox runat="server" ID="txt_username" CssClass="text" />
            <span>Usuario</span>

            <br />
            <br />

            <asp:TextBox runat="server" ID="txt_password" CssClass="text" TextMode="Password" />
            <span>Contraseña</span>
            <br />

            <input type="checkbox" id="checkbox-1-1" class="custom-checkbox" />
            <label for="checkbox-1-1">Mantenerme conectado</label>

            <asp:Button ID="btn_acceder" runat="server" CssClass="signin" Text="Iniciar sesión" OnClick="btn_acceder_Click" />
            
            <hr />

            <a href="#">Olvidaste la contraseña?</a>
        </form>

    </div>

</body>
</html>

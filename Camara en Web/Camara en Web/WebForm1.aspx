<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Camara_en_Web.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <select name="" id="listaDispositivos"></select>

        <a runat="server" id="capturarFoto" href="javascript:void(0);" onclick="tomarFoto()">Prueba Captura</a>
       

        <a id="cerrarCamara" runat="server" href="javasacript:void(0);" onclick="cerrarVideo()">Cerrar Camara</a>
        <a id="iniciarCamara" runat="server" href="javascript:void(0);" onclick="iniciarVideo()">Iniciar Camara</a>
        
        <hr>
        <video id="video" runat="server" autoplay ></video>
        <canvas id="canvas" style="display: none;"></canvas>
        <canvas id="canvas1" style="width: 100px; height: 100px;" runat="server"></canvas>

        <img  runat="server" id="foto" style="width : 600px; height: 480px; color: aquamarine; border: 0px;"/>
        <asp:Button Text="text" runat="server" OnClick="guardarFoto" />
    <asp:FileUpload ID="FileUpload1"  runat="server" />
    
    <a id="pruebaLink" runat="server" href=""></a>

    <asp:HiddenField ID="HiddenField1" runat="server" />
    <hr />
    <img runat="server" id="dbImage" />
    <%--<a id="buscarImagen" runat="server" href="javascript:void(0);" onclick="mostrarUltimaImagen" >Buscar Ultima imagen</a>--%>
    <button runat="server" id="boton1" onserverclick="mostrarUltimaImagen">aa</button>
    <asp:Button Text="pruebaBoton" runat="server" OnClick="mostrarUltimaImagen"/>
    <script src="app.js"></script>
</asp:Content>


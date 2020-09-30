<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PruebaControl.ascx.cs" Inherits="Camara_en_Web.PruebaControl" %>

   <select runat="server" id="listaDispositivos" style="display:block; margin-bottom:10px;"></select>
                                                            <a runat="server" id="GuardarFotoLink" href="javascript:void(0);" onserverclick="GuardarFotoInstantanea" style="text-decoration:none; border:1px solid gray;  margin:3px;">Guardar Foto</a>
                                                            <a id="capturarFoto" runat="server" href="javascript:void(0);" onclick="tomarFoto()" style="text-decoration:none; border:1px solid gray; ">Tomar Foto</a>
                                                            <a id="iniciarCamara" runat="server" href="javascript:void(0);" onclick="iniciarVideo()" style="text-decoration:none; border:1px solid gray; " >Mostrar Cámara</a>
                                                            <a id="cerrarCamara" runat="server" href="javascript:void(0);" onclick="cerrarVideo()" style="text-decoration:none; border:1px solid gray; ">Cerrar Cámara</a>
                                                            
                                                            
                                                            <div style="margin: 5px; display:flex; justify-content:space-around; margin-top:5px;">
                                                                <div>
                                                                <video id="video" runat="server" width="300" height="300" autoplay></video>
                                                                </div>
                                                                <div style="display:flex; margin-left:5px; align-items:center; ">
                                                                  <img runat="server" id="captura" alt="Foto" width="300" height="225" style="margin: 300px"/>
                                                                </div>
                                                              
                                                            </div>
                                                              

                                                            
                                                            <canvas id="canvas" runat="server" style="display : none;"></canvas>

                                                            <asp:HiddenField runat="server" ID="imagenBase64" />

<script src="Camara.js"></script>
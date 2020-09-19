<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CamaraP1.aspx.cs" Inherits="Camara_en_Web.CamaraP1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
       <video runat="server" id="video" autoplay="true"></video>
        <button runat="server" id="boton">Tomar foto</button>
    <button runat="server" id="iniciar" onclick="iniciarCamara()">Iniciar</button>
    <%--<asp:Button ID="Button1" runat="server" Text="Button" OnClick="iniciarCamara()"/>--%>
    <asp:Button ID="Button1" runat="server" Text="Inicio 2" OnClick="Button1_Click" />

    <script src="app.js"></script>

    <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
    <asp:ListView ID="img" runat="server">
         <ItemTemplate >
        </ItemTemplate>
    </asp:ListView>
    <asp:GridView ID="GridView1" runat="server" Width="500px" Height="200px" ></asp:GridView>
   
    
    <asp:ImageMap ID="ImageMap1" runat="server"></asp:ImageMap>
    <asp:ImageButton ID="ImageButton1" runat="server" />
    <asp:Image ID="Image1" runat="server" />
    <asp:Label ID="Label1" runat="server"></asp:Label>
   
</asp:Content>

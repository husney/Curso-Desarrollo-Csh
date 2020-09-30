<%@ Page Title="" Language="C#" MasterPageFile="~/Layout.Master" AutoEventWireup="true" CodeBehind="CamaraP1.aspx.cs" Inherits="Camara_en_Web.CamaraP1" %>

<%@ Register Src="~/PruebaControl.ascx" TagPrefix="uc1" TagName="PruebaControl" %>


<%--<%@ Register Src="~/PruebaControl.ascx" TagName="cntCam" TagPrefix="cw" %>--%>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <%--<%@ Register assembly="CamaraWebControl" Namespace="CamaraWeb" TagPrefix="camctr" %>--%>
    
    <uc1:PruebaControl runat="server" id="PruebaControl" />

    
</asp:Content>

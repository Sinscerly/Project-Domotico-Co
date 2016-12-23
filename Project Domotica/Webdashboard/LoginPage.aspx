<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/restricted/Members.aspx"></asp:Login>
        <asp:ChangePassword ID="ChangePassword1" runat="server"></asp:ChangePassword>
        <asp:LoginStatus ID="LoginStatus1" runat="server" />
</asp:Content>

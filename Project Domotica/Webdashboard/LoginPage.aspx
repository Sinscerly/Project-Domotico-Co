<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblLogin" runat="server" Text="Login"></asp:Label>
    <asp:Label ID="lblGNaam" runat="server" Text="Gebruikersnaam:"></asp:Label>
    <asp:TextBox ID="txtGNaam" runat="server"></asp:TextBox>
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lblGNaam" runat="server" Text="Gebruikersnaam:"></asp:Label>
    <asp:TextBox ID="txtGNaam" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblWachtwoord" runat="server" Text="Wachtwoord:"></asp:Label>
    <asp:TextBox ID="TxtWachtwoord" runat="server" style="margin-bottom: 0px"></asp:TextBox>
    <br />
    <asp:Button ID="BtnLogin" runat="server" Text="Login" />
    <br />
    <asp:Button ID="BtnSignUp" runat="server" Text="Registreer" OnClick="BtnSignUp_Click" />
    <br />
    <br />
    <asp:Label ID="lblVoorNaam" runat="server" Text="Voornaam:"></asp:Label>
    <asp:TextBox ID="TxtVoornaam" runat="server"></asp:TextBox>
    <br />
    <asp:Label ID="lblAchterNaam" runat="server" Text="Achternaam"></asp:Label>
    <asp:TextBox ID="txtAchterNaam" runat="server"></asp:TextBox>
</asp:Content>

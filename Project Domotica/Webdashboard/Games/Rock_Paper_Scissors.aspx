<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="Rock_Paper_Scissors.aspx.cs" Inherits="Webdashboard.Games.Rock_Paper_Scissors" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class=" Content">
        <div id="Button_bar">
            <asp:Button ID="btn_Rock" runat="server" Text="Rock" CssClass="Button" OnClick="UserChose"/>
            <asp:Button ID="btn_Paper" runat="server" Text="Paper" CssClass="Button" OnClick="UserChose"/>
            <asp:Button ID="btn_Scissor" runat="server" Text="Scissor" CssClass="Button" OnClick="UserChose"/>
        </div>
        <div>
            <br />
            <asp:Label ID="lbl_PlayerHasChosen" runat="server" Text=""></asp:Label>
            <asp:Label ID="lbl_ComputerHasChosen" runat="server" Text=""></asp:Label>
            <br />
            <asp:Label ID="lbl_WhoWins" runat="server" Font-Size="XX-Large"></asp:Label>
            <br />
        </div>
        <div>
            <asp:Button ID="btn_Retry" runat="server" Text="Retry" Visible="False" CssClass="Button" OnClick="Retry"/>
        </div>
    </div>
    

</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="Webdashboard.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="..\Opmaak.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <p> 
        
        &nbsp;<p>
        
        <strong>What would you like to do?</strong><p>
            <asp:Button ID="ButtonGames" runat="server" Height="43px" OnClick="ButtonGames_Click"  Text="Games" Width="86px" CssClass="Button" />
         
            <asp:Button ID="ButtonEntertainment" runat="server" Height="43px" Text="Entertainment" OnClick="ButtonEntertainment_Click" CssClass="Button" />

                <asp:Button ID="ToolsButton" runat="server" Height="44px" OnClick="Button4_Click1" Text="Tools" Width="74px" CssClass="Button" />

            <asp:Button ID="DomoticaButton" runat="server" Height="44px" Text="Domotica" Width="71px" OnClick="Domotica_OnClick" CssClass="Button" />

                </p>
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Hit the dot" Visible="False" CssClass="Button" />
            <asp:Button ID="Button2" runat="server" Height="38px" OnClick="Button2_Click" Text="Country Guessing" Visible="False" CssClass="Button" />
            <asp:Button ID="Button3" runat="server" Height="38px" OnClick="Button3_Click" Text="2048" Width="61px" Visible="False" CssClass="Button" />

                </p>
        <p>
            <asp:Button ID="YoutubeButton" runat="server" Height="31px" OnClick="Button4_Click" Text="Youtube" Visible="False" Width="82px" CssClass="Button" />
            <asp:Button ID="NetflixButton" runat="server" Height="32px" Text="Netflix" Visible="False" Width="74px" OnClick="NetflixButton_Click" CssClass="Button" />

                </p>
        <p>
            <asp:Button ID="CalcButton" runat="server" Height="29px" OnClick="CalcButton_Click" Text="Calculator" Visible="False" Width="135px" CssClass="Button" />
            <asp:Button ID="InhollandButton" runat="server" Height="30px" OnClick="InhollandButton_Click" Text="Email Inholland" Visible="False" Width="120px" CssClass="Button" />
    </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        
</asp:Content>


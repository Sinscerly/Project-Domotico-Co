<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="Webdashboard.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   <p>
        
     Wat wilt u doen?<p>
            <asp:Button ID="ButtonGames" runat="server" Height="43px" OnClick="ButtonGames_Click" Text="Games" Width="86px" />

                </p>
        <p>
            <asp:Button ID="Button1" runat="server" Height="38px" OnClick="Button1_Click" Text="Hit the dot" Visible="False" />
            <asp:Button ID="Button2" runat="server" Height="38px" OnClick="Button2_Click" Text="Country Guessing" Visible="False" />
            <asp:Button ID="Button3" runat="server" Height="38px" OnClick="Button3_Click" Text="2048" Width="61px" Visible="False" />

                </p>
        <p>
            <asp:Button ID="ButtonEntertainment" runat="server" Height="43px" Text="Entertainment" OnClick="ButtonEntertainment_Click" />

                </p>
        <p>
            <asp:Button ID="YoutubeButton" runat="server" Height="31px" OnClick="Button4_Click" Text="Youtube" Visible="False" Width="82px" />
            <asp:Button ID="NetflixButton" runat="server" Height="32px" Text="Netflix" Visible="False" Width="74px" OnClick="NetflixButton_Click" />
        </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            <asp:Button ID="ButtonZorg" runat="server" Height="42px" Text="Domotica" Width="72px" OnClick="ButtonZorg_Click" />

                </p>
        
</asp:Content>


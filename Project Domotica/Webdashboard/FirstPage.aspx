<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="FirstPage.aspx.cs" Inherits="Webdashboard.FirstPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
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
            <asp:Button ID="Hit_The_Dot" runat="server" Height="38px" Text="Hit the dot" Visible="False" CssClass="Button" PostBackUrl="~/Games/HitTheDot.aspx" OnClick="Hit_The_Dot_Click" />
            <asp:Button ID="Country_Guessing" runat="server" Height="38px" Text="Country Guessing" Visible="False" CssClass="Button" PostBackUrl="~/Games/CountryGuessing.aspx" />
            <asp:Button ID="G2048" runat="server" Height="38px" Text="2048" Width="61px" Visible="False" CssClass="Button" PostBackUrl="~/Games/2048.aspx" OnClick="G2048_Click" />

                </p>
        <p>
            <asp:Button ID="YoutubeButton" runat="server" Height="31px" OnClick="Button4_Click" Text="Youtube" Visible="False" Width="82px" CssClass="Button" />
            <asp:Button ID="NetflixButton" runat="server" Height="32px" Text="Netflix" Visible="False" Width="74px" OnClick="NetflixButton_Click" CssClass="Button" />
            <asp:Button ID="UselessButton" runat="server" Text="UselessButton" Visible="False" CssClass="Button" Height="31px" OnClick="UselessButton_Click" />
                </p>
    <p>
            <asp:Label ID="lblUseless" runat="server" Text="Clicked on the UselessButton:  " Visible="False"></asp:Label>
            <asp:Label ID="lblUselessTeller" runat="server" Visible="False"></asp:Label>
                </p>
        <p>
            <asp:Button ID="LinksButton" runat="server" Text="Links" CssClass="Button" Height="27px" OnClick="LinksButton_Click" Width="56px" Visible="False" />
            <asp:Button ID="CalcButton" runat="server" Height="29px" OnClick="CalcButton_Click" Text="Calculator" Visible="False" Width="135px" CssClass="Button" PostBackUrl="~/restricted/Tools/calc.aspx" />
            <asp:Button ID="InhollandButton" runat="server" Height="30px" OnClick="InhollandButton_Click" Text="Email Inholland" Visible="False" Width="120px" CssClass="Button" />
    </p>
    <p>
        <asp:Button ID="CustomButton1" runat="server" Text="Button1" CssClass="Button" Height="33px" Width="93px" Visible="False" OnClick="CustomButton1_Click" />
        <asp:Button ID="CustomButton2" runat="server" Text="Button2" CssClass="Button" Height="32px" Width="93px" Visible="False" OnClick="CustomButton2_Click" />
        <asp:Button ID="CustomButton3" runat="server" Text="Button3" CssClass="Button" Height="32px" Width="93px" Visible="False" OnClick="CustomButton3_Click" />
           <asp:Button ID="Customize" runat="server" Text="Customize" CssClass="Button" Height="20px" Width="67px" Visible="False" OnClick="Customize_Click"/>
         </p>
        <p>
          
        </p>
    <asp:Panel ID="Panel1" runat="server">
    </asp:Panel>
    <p>
        <asp:ListBox ID="ListBox" runat="server" Visible="False">
            <asp:ListItem>Button 1</asp:ListItem>
            <asp:ListItem>Button 2</asp:ListItem>
            <asp:ListItem>Button 3</asp:ListItem>
        </asp:ListBox>
            &nbsp;</p>
    <p>
            <asp:Label ID="Label1" runat="server" Text="Button naam: " Visible="False"></asp:Label>
            <asp:TextBox ID="txtButtonnaam" runat="server" Visible="False"></asp:TextBox>
    </p>
    <p>
            <asp:Label ID="Label2" runat="server" Text="Link adres: " Visible="False"></asp:Label>
&nbsp;
            <asp:TextBox ID="txtLinkAdres" runat="server" Visible="False"></asp:TextBox>
    </p>
    <p>
            <asp:Button ID="SubmitMYB" runat="server" CssClass="Button" Text="Submit" Visible="False" OnClick="SubmitMYB_Click" />
    </p>
        <p>
            <asp:Label ID="lblError" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
</asp:Content>


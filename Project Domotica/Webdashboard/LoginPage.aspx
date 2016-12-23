<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex ="0">
        <asp:View ID="Login" runat="server">
            <asp:Login ID="Login1" runat="server" DestinationPageUrl="~/FirstPage.aspx"></asp:Login>
            <asp:Button CommandArgument="1" CommandName="SwitchViewByIndex" ID="BTNRegister" runat="server" Text="Register" OnClick="BTNRegister_Click" />
            <asp:Button CommandArgument="2" CommandName="SwitchViewByIndex" ID="BTNChangePass" runat="server" Text="Change Password" OnClick="BTNChangePass_Click" />
        </asp:View>
        <asp:View ID="Register" runat="server">
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
            <WizardSteps>
                <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                </asp:CreateUserWizardStep>
                <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                </asp:CompleteWizardStep>
            </WizardSteps>
        </asp:CreateUserWizard>
        </asp:View>
        <asp:View ID="ChangePass" runat="server">
            <asp:ChangePassword ID="ChangePassword1" runat="server"></asp:ChangePassword>
        </asp:View>


    </asp:MultiView>
        
        
        
</asp:Content>

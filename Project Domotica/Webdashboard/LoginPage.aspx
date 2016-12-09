<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">




</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex ="0">
        <asp:View ID="View1" runat="server" >
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
            <asp:Button ID="BtnSignUp" runat="server" Text="Registreer" CommandName ="NextView" />
        </asp:View>
        <asp:View ID="View2" runat="server">
            <asp:CreateUserWizard ID="CreateUserWizard1" runat="server">
                <WizardSteps>
                    <asp:CreateUserWizardStep ID="CreateUserWizardStep1" runat="server">
                    </asp:CreateUserWizardStep>
                    <asp:CompleteWizardStep ID="CompleteWizardStep1" runat="server">
                    </asp:CompleteWizardStep>
                </WizardSteps>
            </asp:CreateUserWizard> 



        </asp:View>
    </asp:MultiView>
</asp:Content>

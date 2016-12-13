<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="Webdashboard.LoginPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

    <link href="Opmaak.css" rel="stylesheet" type="text/css" /
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:MultiView ID="MultiView1" runat="server" ActiveViewIndex ="0">
        <asp:View ID="Login" runat="server" >
            <asp:Login ID="Login1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt" Height="193px" Width="270px">
                <LayoutTemplate>
                    <table cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                        <tr>
                            <td>
                                <table cellpadding="0">
                                    <tr>
                                        <td align="center" colspan="2" style="color:White;background-color:#6B696B;font-weight:bold;">Log In</td>
                                    </tr>
                                    <tr>
                                        <td align="right">
                                            <asp:Label ID="UserNameLabel" runat="server" AssociatedControlID="UserName">User Name:</asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="UserName" runat="server"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="UserNameRequired" runat="server" ControlToValidate="UserName" ErrorMessage="User Name is required." ToolTip="User Name is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style3">
                                            <asp:Label ID="PasswordLabel" runat="server" AssociatedControlID="Password">Password:</asp:Label>
                                        </td>
                                        <td class="auto-style2">
                                            <asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="PasswordRequired" runat="server" ControlToValidate="Password" ErrorMessage="Password is required." ToolTip="Password is required." ValidationGroup="Login1">*</asp:RequiredFieldValidator>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td colspan="2">
                                            <asp:CheckBox ID="RememberMe" runat="server" Text="Remember me next time." />
                                        </td>
                                    </tr>
                                    <tr>
                                        <td align="center" colspan="2" style="color:Red;">
                                            <asp:Literal ID="FailureText" runat="server" EnableViewState="False"></asp:Literal>
                                        </td>
                                    </tr>
                                    <tr>
                                        <td class="auto-style1" colspan="2">
                                            <br />
                                            <asp:Button ID="BtnSignUp" runat="server" CommandName="NextView" Text="Registreer" />
                                            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                            <asp:Button ID="LoginButton" runat="server" CommandName="Login" Text="Log In" ValidationGroup="Login1" />
                                            <br />
                                            <br />
                                            <asp:LinkButton ID="lbtn_ForgotPassword" runat="server" commandname="SwitchViewByID" CommandArgument="PasswordRecovery">Forgot Your Password?</asp:LinkButton>
                                            <br />
                                            </td>
                                    </tr>
                                </table>
                            </td>
                        </tr>
                    </table>
                </LayoutTemplate>
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:Login>
        </asp:View>
        <asp:View ID="Register" runat="server">
            
            <table  cellpadding="1" cellspacing="0" style="border-collapse:collapse;">
                <tr>
                    <td>
                        <table cellpadding="0">
                            <tr>
                                        <td align="center" colspan="2" style="color:White;background-color:#6B696B;font-weight:bold;">Registreer</td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblUserName" runat="server" Text="Gebruikersnaam:"></asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtUserName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblPassword" runat="server" Text="Wachtwoord:"></asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtPassword" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblFirstName" runat="server" Text="Voornaam:"></asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblLastName" runat="server" Text="Achternaam:"></asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblEmail" runat="server" Text="Email:"></asp:Label>
                                </td>
                                <td class="auto-style2">
                                    <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
                                </td>
                            </tr>
                            <tr>
                                <td class="auto-style3">
                                    <asp:Label ID="lblGeboorteD" runat="server" Text="Geboortedatum:"></asp:Label>
                                </td>
                               <td class="auto-style2">
                                    <asp:TextBox ID="txtGeboorteD" runat="server"></asp:TextBox>
                                </td> 
                                
                            </tr> 
                            <tr>
                                <td>
                                    <asp:Button ID="btnCreate" runat="server" Text="Registreer" OnClick="btnCreate_Click" />
                                </td>
                            </tr>
                        </table>
                    </td>
                </tr>
       </table>
             
        </asp:View>
        <asp:View ID="PasswordRecovery" runat="server">


            <asp:PasswordRecovery ID="PasswordRecovery1" runat="server" BackColor="#F7F7DE" BorderColor="#CCCC99" BorderStyle="Solid" BorderWidth="1px" Font-Names="Verdana" Font-Size="10pt">
                <TitleTextStyle BackColor="#6B696B" Font-Bold="True" ForeColor="#FFFFFF" />
            </asp:PasswordRecovery>


        </asp:View>
    </asp:MultiView>
    <asp:Label ID="lblConnectionFeedback" runat="server" Text=""></asp:Label>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DaHouseControl.aspx.cs" Inherits="Webdashboard.DaHouseControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
    <title>DaHouse</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="Connect" runat="server" Text="Refresh" OnClick="Connect_Click1" />
        <asp:Label ID="Connect_info" runat="server" Text=""></asp:Label> <br />
    </div>

    <div>
        <div class="Button">
            Lamp 1
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp1" runat="server" OnCheckedChanged="Toggle_Lamp" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 2
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp2" runat="server" AutoPostBack="True" OnCheckedChanged="Toggle_Lamp" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 3
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp3" runat="server" AutoPostBack="True" OnCheckedChanged="Toggle_Lamp" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 4
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp4" runat="server" AutoPostBack="True" OnCheckedChanged="Toggle_Lamp" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 5
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp5" runat="server" AutoPostBack="True" OnCheckedChanged="Toggle_Lamp" />
            <div class="slider round"></div>
            </label>
        </div>
    </div>
    <div>
        <br />
        <div class="Button">
            Raam 1
            <label class="switch">
            <asp:CheckBox ID="cbtn_window1" runat="server" OnCheckedChanged="Toggle_Window" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Raam 2
            <label class="switch">
            <asp:CheckBox ID="cbtn_window2" runat="server" OnCheckedChanged="Toggle_Window" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
    </div>
        <br />
    <div>
        <asp:TextBox ID="Txt_heater" runat="server"></asp:TextBox>
        <asp:Button ID="btn_heater" runat="server" Text="Button" OnClick="Change_Heater" />
    </div>

    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>
<asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="Txt_heater" ErrorMessage="Voer getal tussen de 12 en 35" MaximumValue="35" MinimumValue="12"></asp:RangeValidator>
</asp:Content>


    

    
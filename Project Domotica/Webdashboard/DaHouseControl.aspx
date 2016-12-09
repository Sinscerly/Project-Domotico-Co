<%@ Page Title="" Language="C#" MasterPageFile="~/DashboardMaster.Master" AutoEventWireup="true" CodeBehind="DaHouseControl.aspx.cs" Inherits="Webdashboard.DaHouseControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Opmaak.css" rel="stylesheet" type="text/css" />
    <title>DaHouse</title>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <asp:Button ID="Connect" runat="server" Text="Connect" OnClick="Connect_Click1" />
        <asp:Label ID="Connect_info" runat="server" Text=""></asp:Label> <br />
    </div>
    <div>
        <div class="Button">
            Lamp 1
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp1" runat="server" OnCheckedChanged="cbtn_Lamp1_CheckedChanged" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 2
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp2" runat="server" AutoPostBack="True" OnCheckedChanged="cbtn_Lamp2_CheckedChanged" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 3
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp3" runat="server" AutoPostBack="True" OnCheckedChanged="cbtn_Lamp3_CheckedChanged" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 4
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp4" runat="server" AutoPostBack="True" OnCheckedChanged="cbtn_Lamp4_CheckedChanged" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Lamp 5
            <label class="switch">
            <asp:CheckBox ID="cbtn_Lamp5" runat="server" AutoPostBack="True" OnCheckedChanged="cbtn_Lamp5_CheckedChanged" />
            <div class="slider round"></div>
            </label>
        </div>
        <br />
        <div class="Button">
            Raam 1
            <label class="switch">
            <asp:CheckBox ID="cbtn_window1" runat="server" OnCheckedChanged="cbtn_window1_CheckedChanged" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
        <div class="Button">
            Raam 2
            <label class="switch">
            <asp:CheckBox ID="cbtn_window2" runat="server" OnCheckedChanged="cbtn_window2_CheckedChanged" AutoPostBack="True" />
            <div class="slider round"></div>
            </label>
        </div>
        <br />
        <asp:TextBox ID="Txt_heater" runat="server"></asp:TextBox>
        <asp:Button ID="btn_heater" runat="server" Text="Button" OnClick="btn_heater_Click" />
    </div>

    <asp:Label ID="lbl_info" runat="server" Text="Label"></asp:Label>

</asp:Content>


    

    
<%@ Page Title="" Language="C#" MasterPageFile="~/Admin.Master" AutoEventWireup="true" CodeBehind="changePassword.aspx.cs" Inherits="WebApplication1.WebForm9" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 100%;
    }
    .auto-style2 {
        height: 30px;
    }
    .auto-style3 {
        height: 34px;
    }
    .auto-style4 {
        height: 33px;
    }
    .auto-style5 {
        height: 30px;
        width: 286px;
    }
    .auto-style6 {
        height: 34px;
        width: 286px;
    }
    .auto-style7 {
        height: 33px;
        width: 286px;
    }
    .auto-style8 {
        width: 286px;
    }
    .auto-style9 {
        height: 30px;
        width: 168px;
    }
    .auto-style10 {
        height: 34px;
        width: 168px;
    }
    .auto-style11 {
        height: 33px;
        width: 168px;
    }
    .auto-style12 {
        width: 168px;
    }
    .auto-style13 {
        height: 30px;
        width: 216px;
    }
    .auto-style14 {
        height: 34px;
        width: 216px;
    }
    .auto-style15 {
        height: 33px;
        width: 216px;
    }
    .auto-style16 {
        width: 216px;
    }
    .auto-style21 {
        height: 56px;
        width: 286px;
    }
    .auto-style22 {
        height: 56px;
        width: 168px;
    }
    .auto-style23 {
        height: 56px;
        width: 216px;
    }
    .auto-style24 {
        height: 56px;
    }
    .auto-style25 {
        height: 27px;
        width: 286px;
    }
    .auto-style26 {
        height: 27px;
        width: 168px;
    }
    .auto-style27 {
        height: 27px;
        width: 216px;
    }
    .auto-style28 {
        height: 27px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style5">&nbsp;</td>
        <td class="auto-style9">Old Password :</td>
        <td class="auto-style13">
            <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Width="197px"></asp:TextBox>
        </td>
        <td class="auto-style2">
            <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style6"></td>
        <td class="auto-style10">New Password:</td>
        <td class="auto-style14">
            <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="197px"></asp:TextBox>
        </td>
        <td class="auto-style3">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="This field is required" ForeColor="#FF3300"></asp:RequiredFieldValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style7"></td>
        <td class="auto-style11">Confirm Password:</td>
        <td class="auto-style15">
            <asp:TextBox ID="TextBox3" runat="server" TextMode="Password" Width="197px"></asp:TextBox>
        </td>
        <td class="auto-style4">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="This field is required" ForeColor="Red"></asp:RequiredFieldValidator>
            <br />
            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password don't match" ForeColor="Red"></asp:CompareValidator>
        </td>
    </tr>
    <tr>
        <td class="auto-style25"></td>
        <td class="auto-style26"></td>
        <td class="auto-style27"></td>
        <td class="auto-style28"></td>
    </tr>
    <tr>
        <td class="auto-style21"></td>
        <td class="auto-style22"></td>
        <td class="auto-style23">
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Change Password" Width="181px" />
&nbsp; </td>
        <td class="auto-style24">
            <asp:Label ID="Label2" runat="server" ForeColor="#009933" style="font-weight: 700"></asp:Label>
        </td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
    <tr>
        <td class="auto-style8">&nbsp;</td>
        <td class="auto-style12">&nbsp;</td>
        <td class="auto-style16">&nbsp;</td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>

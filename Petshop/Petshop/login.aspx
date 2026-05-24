<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1 align="center"><b><u>Login Form</u></b></h1> <br />
    <br /><br />
    <table style="width: 50%" align="center">
        <tr>
            <td>Enter Username</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Enter Password</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="margin-left: 80px">
                <asp:Button ID="Button1" runat="server" Text="Reset" Width="95px" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Login" Width="85px" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td><a href="register.aspx">Register As new User</a></td>
            <td><a href="admin/login.aspx"> Admin Login</a></td>
            <td></td>
        </tr>
    </table>
    <br /><br />
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="card.aspx.cs" Inherits="card" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<table style="width: 80%; border: 1px solid #c0c0c0">
    <tr>
        <td>Enter Card No</td>
        <td>
            <asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Enter Bank Name</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server" required="required"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Enter CVV Code</td>
        <td>
            <asp:TextBox ID="TextBox3" runat="server" required="required"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Enter Expiry Date On the Card</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server" required="required"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>Amount</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
        </td>
    </tr>
</table>
</asp:Content>

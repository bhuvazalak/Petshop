<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="show_product_details.aspx.cs" Inherits="show_product_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:Literal ID="Literal2" runat="server"></asp:Literal>
<br />
Enter No Of Qty :-
<asp:TextBox ID="TextBox1" runat="server" required="required"></asp:TextBox>
<br />
<br />
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Add To Cart" />
&nbsp;
    &nbsp;
</asp:Content>


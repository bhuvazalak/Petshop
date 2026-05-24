<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="feedback.aspx.cs" Inherits="admin_feedback" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <h2>Contact Details</h2>
    <br />

    <asp:GridView ID="GridView1" runat="server" 
        AutoGenerateColumns="True" 
        Width="100%" 
        BorderWidth="1px">
    </asp:GridView>

</asp:Content>

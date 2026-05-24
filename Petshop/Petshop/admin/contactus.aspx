<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master"
    AutoEventWireup="true" CodeFile="contactus.aspx.cs" Inherits="admin_contactus" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="admin-dashboard">
        <div class="admin-dashboard-header">
            <h2>Contact Messages</h2>
            <p>All messages submitted from the Contact Us form</p>
        </div>

        <div class="card" style="padding: 1.25rem;">
            <asp:GridView ID="GridView1" runat="server"
                CssClass="table table-striped table-bordered"
                AutoGenerateColumns="true"
                BorderWidth="0"
                Width="100%">
            </asp:GridView>
        </div>
    </div>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="admin_home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div class="admin-dashboard">
        <div class="admin-dashboard-header">
            <h2>Admin Dashboard</h2>
            <p>Overview of your store activity</p>
        </div>

        <div class="admin-stats-grid">
            <div class="admin-stat-card users">
                <div class="stat-label">Total Users</div>
                <div class="stat-value">
                    <asp:Label ID="lblTotalUsers" runat="server" Text="0"></asp:Label>
                </div>
            </div>

            <div class="admin-stat-card products">
                <div class="stat-label">Total Products</div>
                <div class="stat-value">
                    <asp:Label ID="lblTotalProducts" runat="server" Text="0"></asp:Label>
                </div>
            </div>

            <div class="admin-stat-card categories">
                <div class="stat-label">Total Categories</div>
                <div class="stat-value">
                    <asp:Label ID="lblTotalCategories" runat="server" Text="0"></asp:Label>
                </div>
            </div>

            <div class="admin-stat-card orders">
                <div class="stat-label">Total Orders</div>
                <div class="stat-value">
                    <asp:Label ID="lblTotalOrders" runat="server" Text="0"></asp:Label>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="categories.aspx.cs" Inherits="categories" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- Page Title -->
    <h1 class="page-title">Categories</h1>

    <!-- Categories Container -->
    <div class="category-container">
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    </div>

    <!-- Page CSS -->
    <style>
        .page-title {
            text-align: center;
            margin: 30px 0;
            font-size: 36px;
            font-weight: bold;
            color: #333;
        }

        .category-container {
            padding: 30px 80px;   /* left-right space */
        }

        .category-table {
            width: 100%;
            margin: auto;
        }

        .category-td {
            text-align: center;
            padding: 25px;
        }

        .category-td img {
            height: 200px;
            width: 200px;
            border-radius: 12px;
            box-shadow: 0 5px 12px rgba(0,0,0,0.25);
        }

        .category-name {
            display: block;
            margin-top: 12px;
            font-size: 18px;
            font-weight: bold;
            color: #000;
            text-decoration: none;
        }

        .category-name:hover {
            color: #e67e22;
        }
    </style>

</asp:Content>

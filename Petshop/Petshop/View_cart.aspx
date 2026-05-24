<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="View_cart.aspx.cs" Inherits="View_cart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="page-title">My Cart</h1>

    <div class="cart-container">
        <asp:Literal ID="Literal2" runat="server"></asp:Literal>
    </div>

    <style>
        body {
            background-color: #f6f7fb;
        }

        .page-title {
            text-align: center;
            margin: 30px 0;
            font-size: 36px;
            font-weight: bold;
            color: #333;
        }

        .cart-container {
            padding: 20px 70px 50px 70px;
        }

        .cart-table {
            width: 100%;
            background: #fff;
            border-collapse: collapse;
            border-radius: 12px;
            overflow: hidden;
            box-shadow: 0 6px 15px rgba(0,0,0,0.15);
        }

        .cart-table th {
            background: #343a40;
            color: #fff;
            padding: 12px;
            text-align: center;
        }

        .cart-table td {
            padding: 12px;
            text-align: center;
            border-bottom: 1px solid #ddd;
        }

        .cart-table img.product-img {
            height: 90px;
            width: 90px;
            border-radius: 10px;
        }

        .delete-btn img {
            height: 35px;
            width: 35px;
            cursor: pointer;
        }

        .cart-footer {
            margin-top: 25px;
            text-align: center;
        }

        .total-text {
            font-size: 22px;
            font-weight: bold;
            margin-bottom: 15px;
        }

        .btn-checkout {
            padding: 10px 30px;
            background: #28a745;
            color: #fff;
            border-radius: 6px;
            text-decoration: none;
            font-size: 16px;
            margin-right: 15px;
        }

        .btn-continue {
            padding: 10px 30px;
            background: #007bff;
            color: #fff;
            border-radius: 6px;
            text-decoration: none;
            font-size: 16px;
        }

        .btn-checkout:hover {
            background: #218838;
        }

        .btn-continue:hover {
            background: #0056b3;
        }
    </style>

</asp:Content>

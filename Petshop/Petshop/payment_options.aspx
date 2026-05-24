<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="payment_options.aspx.cs" Inherits="payment_options" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h1 class="page-title">Choose Payment Method</h1>

    <div class="payment-wrapper">

        <!-- CASH ON DELIVERY -->
        <div class="payment-card">
            <asp:RadioButton ID="RadioButton1" runat="server"
                GroupName="r1"
                AutoPostBack="True"
                OnCheckedChanged="RadioButton1_CheckedChanged" />
            <span>Cash On Delivery</span>
        </div>

        <!-- CARD PAYMENT -->
        <div class="payment-card">
            <asp:RadioButton ID="RadioButton2" runat="server"
                GroupName="r1"
                AutoPostBack="True"
                OnCheckedChanged="RadioButton2_CheckedChanged" />
            <span>Card Payment</span>
        </div>

    </div>

    <!-- CSS -->
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

        .payment-wrapper {
            display: flex;
            justify-content: center;
            gap: 40px;
            margin-top: 40px;
            margin-bottom: 60px;
        }

        .payment-card {
            width: 280px;
            background: #fff;
            padding: 30px;
            text-align: center;
            border-radius: 12px;
            box-shadow: 0 6px 15px rgba(0,0,0,0.15);
            font-size: 20px;
            cursor: pointer;
            transition: transform 0.3s;
        }

        .payment-card:hover {
            transform: translateY(-5px);
        }

        .payment-card span {
            margin-left: 10px;
            font-weight: bold;
            color: #333;
        }

        .payment-card input[type=radio] {
            transform: scale(1.5);
            cursor: pointer;
        }
    </style>

</asp:Content>

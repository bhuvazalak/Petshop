<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master"
    AutoEventWireup="true" CodeFile="home.aspx.cs" Inherits="home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <!-- PAGE TITLE -->
    <h1 class="page-title">Welcome to Pet Shop</h1>

    <!-- IMAGE SECTION -->
    <div class="home-container">
        <marquee behavior="scroll" direction="left" scrollamount="15">
            <img src="Project_images/blog-1.jpg" alt="Blog Image" />
            <img src="Project_images/offer.jpg" alt="Offer Image" />
            <img src="Project_images/product-1.png" alt="Product Image" />
            <img src="Project_images/chain belt.jpg" alt="chain belt" />
            <img src="Project_images/belt.jpg" alt="belt" />
            <img src="Project_images/medicine.jpg" alt="medicine" />
            <img src="Project_images/leather belt1.jpg" alt="leather belt1." />

        </marquee>
    </div>

    <!-- PAGE CSS -->
    <style>
        /* Common heading for all pages */
        .page-title {
            text-align: center;
            margin: 30px 0;
            font-size: 36px;
            font-weight: bold;
            color: #333;
        }

        /* Home page container */
        .home-container {
            padding: 30px 70px;     /* left-right space */
        }

        /* Home page images */
        .home-container img {
            height: 350px;
            width: 350px;
            margin: 0 25px;         /* space between images */
            border-radius: 12px;
            box-shadow: 0 6px 12px rgba(0,0,0,0.25);
        }
    </style>

</asp:Content>

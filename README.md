# Pet Medicine, Food & Belt Online Shopping System

## Project Description

Pet Medicine, Food & Belt Online Shopping System is an online shopping application developed using **ASP.NET (.NET Framework)**. This project allows users to browse and purchase pet-related products such as medicines, food items, pet belts, and accessories.

The system contains two panels:

### User Website
Users can:
- Register and login
- View pet products
- Search products
- Add products to cart
- Place orders
- View order details

### Admin Panel
Admin can:
- Login securely
- Manage products
- Add/Edit/Delete products
- Manage categories
- View customer orders
- Manage users

---

## Technologies Used

- ASP.NET (.NET Framework)
- C#
- SQL Server
- HTML
- CSS
- Visual Studio

---

## How to Open Project in Visual Studio

### Step 1: Extract Project Folder

Extract the project zip file (if compressed).

### Step 2: Open Visual Studio

Open **Visual Studio**.

### Step 3: Open Project

Click:

```text
File → Open → Project/Solution
Select project solution file:

ProjectName.sln

Click Open.

Restore Database

Open SQL Server and import the database file.

Update database connection string if required.

 Run Project

Press: F5

or click: Start

Admin Panel Login

To open Admin Panel:

Open browser and enter:

http://localhost:49711/admin/Login.aspx

Login page file:

Login.aspx

Run steps:

Solution Explorer
→ Admin Folder
→ Login.aspx
→ Right Click
→ View in Browser


User Website Login

To open User Website:

Open browser:

http://localhost:49711/login.aspx

Run steps:

Solution Explorer
→ login.aspx
→ Right Click
→ View in Browser

Project Modules

Admin Module

Admin Login
Product Management
Category Management
Order Management
User Management

User Module

Registration
Login
Product View
Cart
Order Placement
Order History
Project Structure
PetShoppingProject/
│
├── Admin/
│   └── Login.aspx
│
├── Login.aspx
├── Products/
├── Cart/
├── Orders/
├── Database/
└── ProjectName.sln
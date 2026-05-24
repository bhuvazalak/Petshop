<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="admin_Login" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>Admin Login | Pet Shop</title>

    <link href="vendor/fontawesome-free/css/all.min.css" rel="stylesheet" type="text/css" />
    <link href="css/sb-admin.css" rel="stylesheet" />

    <style type="text/css">
        body {
            min-height: 100vh;
            margin: 0;
            display: flex;
            align-items: center;
            justify-content: center;
            background: radial-gradient(circle at top left, #e0f2fe, transparent 55%),
                        radial-gradient(circle at bottom right, #fce7f3, transparent 55%),
                        #eff6ff;
            font-family: -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, sans-serif;
        }

        .admin-login-wrapper {
            max-width: 420px;
            width: 100%;
            padding: 2.5rem 2.25rem;
            border-radius: 1.5rem;
            background: #ffffff;
            box-shadow: 0 30px 80px rgba(15, 23, 42, 0.18);
        }

        .admin-login-header {
            text-align: center;
            margin-bottom: 1.75rem;
        }

        .admin-login-header h2 {
            margin: 0 0 0.35rem;
            font-size: 1.6rem;
            font-weight: 700;
            color: #111827;
        }

        .admin-login-header p {
            margin: 0;
            color: #6b7280;
            font-size: 0.9rem;
        }

        .admin-login-form .form-group {
            margin-bottom: 1.1rem;
        }

        .admin-login-form label {
            display: block;
            margin-bottom: 0.35rem;
            font-size: 0.9rem;
            font-weight: 500;
            color: #374151;
        }

        .admin-login-form input[type="text"],
        .admin-login-form input[type="password"] {
            width: 100%;
            padding: 0.6rem 0.85rem;
            border-radius: 0.75rem;
            border: 1px solid #d1d5db;
            font-size: 0.95rem;
            outline: none;
            transition: border-color 0.15s ease, box-shadow 0.15s ease, background-color 0.15s ease;
        }

        .admin-login-form input[type="text"]:focus,
        .admin-login-form input[type="password"]:focus {
            border-color: #4f46e5;
            box-shadow: 0 0 0 1px rgba(79, 70, 229, 0.25);
            background-color: #f9fafb;
        }

        .admin-login-actions {
            display: flex;
            justify-content: space-between;
            gap: 0.75rem;
            margin-top: 1.25rem;
        }

        .btn-login,
        .btn-reset {
            flex: 1;
            border-radius: 999px;
            padding: 0.55rem 0.75rem;
            font-size: 0.95rem;
            font-weight: 600;
            letter-spacing: 0.04em;
            border: none;
            cursor: pointer;
            transition: background 0.15s ease, transform 0.05s ease, box-shadow 0.15s ease;
        }

        .btn-login {
            color: #ffffff;
            background: linear-gradient(135deg, #4f46e5, #06b6d4);
            box-shadow: 0 15px 30px rgba(79, 70, 229, 0.35);
        }

        .btn-login:hover {
            background: linear-gradient(135deg, #4338ca, #0891b2);
            transform: translateY(-1px);
            box-shadow: 0 18px 38px rgba(79, 70, 229, 0.4);
        }

        .btn-reset {
            color: #374151;
            background: #f3f4f6;
            box-shadow: 0 0 0 rgba(0,0,0,0);
        }

        .btn-reset:hover {
            background: #e5e7eb;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="admin-login-wrapper">
            <div class="admin-login-header">
                <h2>Admin Login</h2>
                <p>Sign in to manage products, users and orders</p>
            </div>
            <div class="admin-login-form">
                <div class="form-group">
                    <label for="TextBox1">Username</label>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </div>
                <div class="form-group">
                    <label for="TextBox2">Password</label>
                    <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
                </div>
                <div class="admin-login-actions">
                    <asp:Button ID="Button2" runat="server" CssClass="btn-reset" Text="Reset" />
                    <asp:Button ID="Button1" runat="server" CssClass="btn-login" OnClick="Button1_Click" Text="Login" />
                </div>
            </div>
        </div>
    </form>
</body>
</html>

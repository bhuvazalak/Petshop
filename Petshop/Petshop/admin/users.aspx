<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="users.aspx.cs" Inherits="admin_users" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h2>User Details</h2>
<br />

<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False"
DataKeyNames="Id" DataSourceID="SqlDataSource1">

<Columns>

<asp:CommandField ShowDeleteButton="True" ShowEditButton="True" HeaderText="Action" />

<asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="True" />

<asp:BoundField DataField="First_name" HeaderText="First Name" />

<asp:BoundField DataField="Last_name" HeaderText="Last Name" />

<asp:BoundField DataField="Contact_No" HeaderText="Contact No" />

<asp:BoundField DataField="Email" HeaderText="Email" />

<asp:BoundField DataField="Username" HeaderText="Username" />

<asp:BoundField DataField="Password" HeaderText="Password" />

</Columns>

</asp:GridView>


<asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="<%$ ConnectionStrings:ConnectionString %>"

SelectCommand="SELECT * FROM Registration"

DeleteCommand="DELETE FROM Registration WHERE Id=@Id"

UpdateCommand="UPDATE Registration SET First_name=@First_name, Last_name=@Last_name, Contact_No=@Contact_No, E_mail=@E_mail, Username=@Username, Password=@Password WHERE Id=@Id">

<DeleteParameters>
<asp:Parameter Name="Id" Type="Int32" />
</DeleteParameters>

<UpdateParameters>
<asp:Parameter Name="First_name" Type="String" />
<asp:Parameter Name="Last_name" Type="String" />
<asp:Parameter Name="Contact_No" Type="String" />
<asp:Parameter Name="Email" Type="String" />
<asp:Parameter Name="Username" Type="String" />
<asp:Parameter Name="Password" Type="String" />
<asp:Parameter Name="Id" Type="Int32" />
</UpdateParameters>

</asp:SqlDataSource>

</asp:Content>
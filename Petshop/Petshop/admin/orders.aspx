<%@ Page Title="" Language="C#" MasterPageFile="~/admin/AdminMasterPage.master" AutoEventWireup="true" CodeFile="orders.aspx.cs" Inherits="orders" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

<h2>Order Details</h2>
<br />

<asp:GridView ID="GridView1" runat="server"
AutoGenerateColumns="False"
DataKeyNames="Id"
DataSourceID="SqlDataSource1"
AllowPaging="True"
AllowSorting="True"
Width="900px">

<Columns>

<asp:BoundField DataField="Id" HeaderText="Order Id" ReadOnly="True" />

<asp:BoundField DataField="Custid" HeaderText="Customer Id" />

<asp:BoundField DataField="Prodid" HeaderText="Product Id" />

<asp:BoundField DataField="Qty" HeaderText="Quantity" />

<asp:BoundField DataField="Amount" HeaderText="Amount" />

</Columns>

</asp:GridView>


<asp:SqlDataSource ID="SqlDataSource1" runat="server"
ConnectionString="<%$ ConnectionStrings:ConnectionString %>"

SelectCommand="SELECT * FROM Orders"

DeleteCommand="DELETE FROM Orders WHERE Id=@Id"

UpdateCommand="UPDATE Orders SET Custid=@Custid, Prodid=@Prodid, Qty=@Qty, Amount=@Amount WHERE Id=@Id"

InsertCommand="INSERT INTO Orders (Custid,Prodid,Qty,Amount) VALUES (@Custid,@Prodid,@Qty,@Amount)">

<DeleteParameters>
<asp:Parameter Name="Id" Type="Int32" />
</DeleteParameters>

<InsertParameters>
<asp:Parameter Name="Custid" Type="Int32" />
<asp:Parameter Name="Prodid" Type="Int32" />
<asp:Parameter Name="Qty" Type="Int32" />
<asp:Parameter Name="Amount" Type="Decimal" />
</InsertParameters>

<UpdateParameters>
<asp:Parameter Name="Custid" Type="Int32" />
<asp:Parameter Name="Prodid" Type="Int32" />
<asp:Parameter Name="Qty" Type="Int32" />
<asp:Parameter Name="Amount" Type="Decimal" />
<asp:Parameter Name="Id" Type="Int32" />
</UpdateParameters>

</asp:SqlDataSource>

</asp:Content>
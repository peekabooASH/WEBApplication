<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ProductUI.aspx.cs" Inherits="ProductApp.UI.ProductUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label3" runat="server" Text="Product Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server" style="margin-left: 9px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Product Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server" style="margin-left: 7px"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Quantity"></asp:Label>
        <asp:TextBox ID="quantityTextBox" runat="server" Width="111px" style="margin-left: 43px"></asp:TextBox>
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" style="margin-left: 16px" Text="Save" Width="128px" />
        <br />
        <br />&nbsp&nbsp&nbsp&nbsp
        <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" style="margin-left: 17px" Text="Show All" Width="131px" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;
        <br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <br />
        <asp:Label ID="Label" runat="server" Text="Total Quantity"></asp:Label>
        <asp:TextBox ID="showQuantityTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

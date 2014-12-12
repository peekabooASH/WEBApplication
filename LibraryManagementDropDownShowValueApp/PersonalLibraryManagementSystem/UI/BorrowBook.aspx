<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBook.aspx.cs" Inherits="PersonalLibraryManagementSystem.UI.BorrowBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Selest a Book"></asp:Label>
        <asp:DropDownList ID="bookDropDownList" runat="server" OnSelectedIndexChanged="bookDropDownList_SelectedIndexChanged" AutoPostBack="True" Height="22px" Width="224px">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
        <asp:Label ID="Label5" runat="server"></asp:Label>
        <br />
    
    </div>
    </form>
</body>
</html>

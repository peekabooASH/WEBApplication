<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BorrowBookUI.aspx.cs" Inherits="ExamApp.UI.BorrowBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label2" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="memberTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="select a Book"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" Height="21px" style="margin-left: 76px" Width="248px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Author"></asp:Label>
        <asp:TextBox ID="authorTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label4" runat="server" Text="Publisher"></asp:Label>
        <asp:TextBox ID="publisherTextBox" runat="server"></asp:TextBox>
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" style="margin-left: 90px" Text="Show" Width="146px" />
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="msgLabel" runat="server"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="borrowButton" runat="server" OnClick="borrowButton_Click" Text="Borrow" />
        <br />
    
    </div>
    </form>
</body>
</html>

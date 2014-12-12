<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBook.aspx.cs" Inherits="PersonalLibraryManagementSystem.UI.ReturnBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Enter Menber No"></asp:Label>
        <asp:TextBox ID="memberNoTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show Borrowed Books" Width="147px" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Borrowed Booklist"></asp:Label>
        <asp:DropDownList ID="bookDropDownList" runat="server" AutoPostBack="True" Height="16px" Width="214px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <asp:Button ID="returnButton" runat="server" Text="Return" Width="66px" />
        <br />
    
    </div>
    </form>
</body>
</html>

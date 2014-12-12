<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ReturnBookUI.aspx.cs" Inherits="ExamApp.UI.ReturnBookUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="Label1" runat="server" Text="Enter Member No"></asp:Label>
        <asp:TextBox ID="memberNoTextBox" runat="server" style="margin-left: 41px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Button ID="showBooksButton" runat="server" OnClick="showBooksButton_Click" style="margin-left: 187px" Text="Show Borrowed Books" Width="286px" />
        <br />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Borrowed BookList"></asp:Label>
        <asp:DropDownList ID="borroedDropDownList" runat="server" Height="22px" style="margin-left: 23px" Width="295px">
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <br />
        <asp:Label ID="msgLabel" runat="server"></asp:Label>
        <br />
        <br />
        <asp:Button ID="returnButton" runat="server" OnClick="returnButton_Click" Text="Return" />
        <br />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="StudentDeptApp.UI.StudentView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
            <asp:DropDownList ID="regshowDropDownList" runat="server" Height="28px" Width="241px">
            </asp:DropDownList>
        </p>
        <p>
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show" />
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="nameshowTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="emailshowTextBox" runat="server"></asp:TextBox>
        </p>
    <div>
    
    </div>
    </form>
</body>
</html>

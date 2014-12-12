<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntry.aspx.cs" Inherits="StudentManagementApp_WebForm.UI.DepartmentEntry" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Department Name:"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        Department Code:<asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="Button2" runat="server" style="margin-left: 207px" Text="Save" Width="102px" OnClick="Button2_Click" />
        <br />
        <asp:Label ID="Label" runat="server"></asp:Label>
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DepartmentEntryUI.aspx.cs" Inherits="StudentDeptApp.UI.DepartmentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Label ID="Label1" runat="server" Text="Department Code"></asp:Label>
        <asp:TextBox ID="codeTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Department Title"></asp:Label>
        <asp:TextBox ID="titleTextBox" runat="server"></asp:TextBox>
        <br />
        <asp:Button ID="deptSaveButton" runat="server" OnClick="deptSaveButton_Click" style="margin-left: 107px" Text="Save" Width="180px" />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

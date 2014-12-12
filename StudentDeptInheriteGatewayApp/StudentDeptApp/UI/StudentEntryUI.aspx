<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntryUI.aspx.cs" Inherits="StudentDeptApp.UI.StudentEntryUI" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <br />
        <asp:Label ID="Label4" runat="server" Text="Department"></asp:Label>
        <asp:DropDownList ID="departmentDropDownList" runat="server" Height="16px" Width="234px">
        </asp:DropDownList>
        <br />
        <br />
    
        <asp:Label ID="Label1" runat="server" Text="RegNo"></asp:Label>
        <asp:TextBox ID="regTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Name"></asp:Label>
        <asp:TextBox ID="nameTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label3" runat="server" Text="Email"></asp:Label>
        <asp:TextBox ID="emailTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" style="margin-left: 90px; height: 26px;" Text="Save" Width="95px" />
        <br />
        <br />
        <asp:Label ID="msglebel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyFirstWebForm.aspx.cs" Inherits="ClassworkWebForms.MyFirstWebForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>My First WebForm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="label" runat="server" Text="" />
            <asp:TextBox ID="text" runat="server" Text="" />
            <asp:Button ID="button" runat="server" Text="Button" OnClick="button_Click" />
        </div>
    </form>
</body>
</html>
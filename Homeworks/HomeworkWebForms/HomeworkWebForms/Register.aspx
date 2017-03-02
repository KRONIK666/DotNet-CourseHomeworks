<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HomeworkWebForms.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="float: left; padding-left: 50px;">
            <asp:Label ID="label1" runat="server" Text="UserName:" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="label2" runat="server" Text="Password:" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="label3" runat="server" Text="Repeat Password:" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="label4" runat="server" Text="Age:" Font-Bold="True"></asp:Label><br />
            <asp:Label ID="label5" runat="server" Text="E-mail:" Font-Bold="True"></asp:Label><br />
        </div>
        <div style="display: block; padding-left: 180px;">
            <asp:TextBox ID="TextBox1" runat="server" Text=""></asp:TextBox><br />
            <asp:TextBox ID="TextBox2" runat="server" Text="" TextMode="Password"></asp:TextBox><br />
            <asp:TextBox ID="TextBox3" runat="server" Text="" TextMode="Password"></asp:TextBox><br />
            <asp:TextBox ID="TextBox4" runat="server" Text=""></asp:TextBox><br />
            <asp:TextBox ID="TextBox5" runat="server" Text=""></asp:TextBox><br />
            <asp:Button ID="button1" runat="server" Text="Register" Font-Size="Medium" OnClick="button1_Click" />
            <asp:Label ID="label6" runat="server" Text="" ForeColor="#ff0000"></asp:Label><br />
        </div>
    </form>
</body>
</html>
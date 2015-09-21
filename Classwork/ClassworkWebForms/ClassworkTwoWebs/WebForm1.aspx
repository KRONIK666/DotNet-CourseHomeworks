<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClassworkTwoWebs.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UEFA</title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:CheckBox id="text" runat="server" OnCheckedChanged="text_CheckedChanged" AutoPostBack="true"/>
        <asp:DropDownList id="choice" runat="server" OnSelectedIndexChanged="choice_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem Text="Choose winner:"/>
            <asp:ListItem Text="Roma"/>
            <asp:ListItem Text="Draw"/>
            <asp:ListItem Text="Barcelona"/>
        </asp:DropDownList>
        <asp:Button id="button" runat="server" Text="Load" Enabled="false" OnClick="button_Click"/>
    </div>
    </form>
</body>
</html>
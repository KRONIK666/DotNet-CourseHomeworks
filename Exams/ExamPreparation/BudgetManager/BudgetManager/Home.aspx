<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BudgetManager.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:LinkButton Text="Home" runat="server" CssClass="button" PostBackUrl="~/Home.aspx" />
            <asp:LinkButton Text="Statistics" runat="server" ID="statisticsBtn" PostBackUrl="~/Statistics.aspx" />
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 5px;">
            <asp:Label Text="Дата:" runat="server" />
            <br />
            <br />
            <asp:Label Text="Тип Разход:" runat="server" />
            <br />
            <br />
            <asp:Label Text="Сума:" runat="server" />
        </div>
        <div style="display: block; padding-left: 100px;">
            <asp:TextBox TextMode="Date" runat="server" ID="dateTxtBox" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="expenseTypeTxtBox" />
            <br />
            <br />
            <asp:TextBox TextMode="Number" runat="server" ID="sumTxtBox" />
            <br />
            <br />
        </div>
        <div style="padding-left: 5px;">
            <asp:Button Text="Добави" runat="server" ID="Button2" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
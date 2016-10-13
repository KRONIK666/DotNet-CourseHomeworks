<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="BudgetManager.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Home" runat="server" CssClass="button" PostBackUrl="~/Home.aspx"/>
            <asp:LinkButton Text="Statistics" runat="server" id="statisticsBtn" PostBackUrl="~/Statistics.aspx"/>
            <br />
            <br />

            <asp:Label Text="Дата:" runat="server" />
            <asp:TextBox TextMode="Date" runat="server" ID="dateTxtBox" />
            <br />
            <br />

            <asp:Label Text="Тип Разход:" runat="server" />
            <asp:TextBox runat="server" ID="expenseTypeTxtBox" />
            <br />
            <br />

            <asp:Label Text="Сума:" runat="server" />
            <asp:TextBox TextMode="Number" runat="server" ID="sumTxtBox" />
            <br />
            <br />

            <asp:Button Text="Добави" runat="server" id="btnSubmit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
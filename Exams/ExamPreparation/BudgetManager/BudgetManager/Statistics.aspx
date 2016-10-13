<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Statistics.aspx.cs" Inherits="BudgetManager.Statistics" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Statistics</title>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:LinkButton Text="Home" runat="server" CssClass="button" PostBackUrl="~/Home.aspx"/>
            <asp:LinkButton Text="Statistics" runat="server" id="statisticsBtn" PostBackUrl="~/Statistics.aspx"/>
            <h1>Статистика:</h1>

            За седмица: 
            <asp:Label Text="" runat="server" id="weeklySum" />
            <br />
            <br />

            За месец: 
            <asp:Label Text="" runat="server" id="monthlySum" />
            <br />
            <br />

            За година: 
            <asp:Label Text="" runat="server" id="annualSum" />
            <br />
            <br />

            <asp:Button Text="Изчисли" runat="server" ID="calculateBtn" OnClick="calculateBtn_Click" />
        </div>
    </form>
</body>
</html>
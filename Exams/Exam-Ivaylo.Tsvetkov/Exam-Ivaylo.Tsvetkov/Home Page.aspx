<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home Page.aspx.cs" Inherits="Exam_Ivaylo.Tsvetkov.Home_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home Page</title>
    <style>
        .button {
            margin-left: 30px;
        }
    </style>
</head>
<body>
    <form id="form" runat="server">
        <div>
            <asp:LinkButton Text="Add New Country" runat="server" CssClass="button" PostBackUrl="~/Home Page.aspx" />
            <asp:LinkButton Text="Search Population" runat="server" CssClass="button" PostBackUrl="~/Search Page.aspx" />
            <br />
            <br />
        </div>
        <div style="float: left; padding-left: 30px;">
            <asp:Label Text="Country:" runat="server" ID="Country" />
            <br />
            <br />
            <asp:Label Text="Capital:" runat="server" ID="Capital" />
            <br />
            <br />
            <asp:Label Text="Population:" runat="server" ID="Population" />
        </div>
        <div style="display: block; padding-left: 150px;">
            <asp:TextBox runat="server" ID="countryTextBox" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="capitalTextBox" />
            <br />
            <br />
            <asp:TextBox TextMode="Number" runat="server" ID="populationTextBox" />
            <asp:Label Style="padding-left: 5px;" runat="server" ID="People" />
            <br />
            <br />
            <asp:Button Text="ADD" runat="server" ID="btnSubmit" OnClick="btnSubmit_Click" />
        </div>
    </form>
</body>
</html>
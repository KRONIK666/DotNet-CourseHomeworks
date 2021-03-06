﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Search Page.aspx.cs" Inherits="Exam_Ivaylo.Tsvetkov.Search_Page" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Population Statistics</title>
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
            <asp:Label Text="Search by country:" runat="server" ID="CountrySearch" />
            <br />
            <br />
            <asp:Label Text="Search by capital:" runat="server" ID="CapitalSearch" />
            <br />
            <br />
            <asp:Label Text="Search by population:" runat="server" ID="PopulationSearch" />
        </div>
        <div style="display: block; padding-left: 180px;">
            <asp:TextBox runat="server" ID="countryTextBox" />
            <br />
            <br />
            <asp:TextBox runat="server" ID="capitalTextBox" />
            <br />
            <br />
            <asp:TextBox TextMode="Number" runat="server" ID="populationTextBox" />
            <br />
            <br />
            <asp:Button Text="SEARCH" runat="server" ID="btnSearch" OnClick="btnSearch_Click" />
        </div>
        <div style="float: left; padding-left: 30px;">
            <h2>Statistics:</h2>

            <asp:Repeater runat="server" ID="infoRepeater">
                <ItemTemplate>
                    <asp:Label Text='<%# Eval("Country") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Capital") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Population") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
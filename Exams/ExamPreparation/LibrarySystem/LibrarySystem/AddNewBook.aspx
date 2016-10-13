<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddNewBook.aspx.cs" Inherits="LibrarySystem.AddNewBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Book</title>
    <style>
        .button {
            margin-right: 100px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:LinkButton Text="Home" runat="server" CssClass="button" PostBackUrl="~/Home.aspx"/>
            <asp:LinkButton Text="Add Book" runat="server" CssClass="button" PostBackUrl="~/AddNewBook.aspx"/>
            <asp:LinkButton Text="Search Books" runat="server" PostBackUrl="~/SearchBook.aspx"/>

            <br />
            <br />

            <asp:Label Text="Title:" runat="server" ID="titleLabel" />
            <asp:TextBox runat="server" id="titleTxtBox" />
            <br />
            <br />

            <asp:Label Text="Author:" runat="server" ID="authorLabel" />
            <asp:TextBox runat="server" id="authorTxtBox" />
            <br />
            <br />

            <asp:Label Text="Price:" runat="server" ID="priceLabel" />
            <asp:TextBox runat="server" id="priceTxtBox" TextMode="Date" />
            <br />
            <br />

            <asp:Label Text="Genre:" runat="server" ID="genreLabel" />
            <asp:TextBox runat="server" id="genreTxtBox" />
            <br />
            <br />

            <asp:Button Text="Add Book" ID="addBookBtn" runat="server" OnClick="addBookBtn_Click"/>
            <asp:Label Text="sss" runat="server" ForeColor="Red" ID="resultLabel"/>
        </div>
    </form>
</body>
</html>
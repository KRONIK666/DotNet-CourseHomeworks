<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="LibrarySystem.SearchBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Book</title>
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

            <asp:Label Text="Keyword: " runat="server" />
            <asp:TextBox runat="server" ID="searchTxtBox" />
            <br />

            <asp:Button Text="Search" runat="server" OnClick="searchBtn_Click" ID="searchBtn" />
            <br />
            <br />

            <asp:Repeater runat="server" ID="booksRepeater">
                <ItemTemplate>
                    <asp:Label runat="server" Text='<%# Eval("Title") %>' />
                    <br />
                    <asp:Label Text='<%# Eval("Author") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Price") %>' runat="server" />
                    <br />
                    <asp:Label Text='<%# Eval("Genre") %>' runat="server" />
                    <br />
                    <br />
                </ItemTemplate>
            </asp:Repeater>
        </div>
    </form>
</body>
</html>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="readme.aspx.cs" Inherits="DbFtw.readme" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>DbFtw WebAPI Sample</h1>
        <hr />

        <ul>
            <li>Works best on Visual Studio 2013 or higher</li>
            <li>Open "Package Manager Console" and run "Update-Package" to download assemblies</li>
            <li>F5 to build and run</li>
            <li>Open http://whateversite/api/DbFtw/Sql/queryFile to execute GET method and see JSON reply</li>
            <li>Open http://whateversite/api/DbFtw/Oracle/queryFile to execute GET method and see JSON reply</li>
        </ul>
        <hr />

        <asp:Label ID="lblVersion" runat="server" Text=""></asp:Label>
    </form>
</body>
</html>

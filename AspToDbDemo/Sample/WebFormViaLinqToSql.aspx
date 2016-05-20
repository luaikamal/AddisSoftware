<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormViaLinqToSql.aspx.cs" Inherits="Sample.WebFormViaLinqToSql" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Reports</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server"></asp:GridView>
            <asp:Button ID="Display" OnClick="DisplayReports_OnClick" runat="server" Text="Display Reports" /><asp:Button ID="InsertReport" OnClick="InsertButton_OnClick" runat="server" Text="Insert Report" />
            <asp:Button ID="UpdateReport" OnClick="UpdateButton_OnClick" runat="server" Text="Update Report" /><asp:Button ID="DeleteReport" OnClick="DeleteButton_OnClick" runat="server" Text="Delete Reports" />
        </div>
    </form>
</body>
</html>

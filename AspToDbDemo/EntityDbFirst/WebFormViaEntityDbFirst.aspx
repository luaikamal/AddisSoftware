<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormViaEntityDbFirst.aspx.cs" Inherits="Sample.WebFormEntityDbFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" DataSourceID="EntityDataSource1">
                <AlternatingRowStyle BackColor="White" />
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:Button ID="Display" OnClick="DisplayReports_OnClick" runat="server" Text="Display Reports" /><asp:Button ID="InsertReport" OnClick="InsertButton_OnClick" runat="server" Text="Insert Report" />
            <asp:Button ID="UpdateReport" OnClick="UpdateButton_OnClick" runat="server" Text="Update Report" /><asp:Button ID="DeleteReport" OnClick="DeleteButton_OnClick" runat="server" Text="Delete Reports" />
        </div>
    </form>
</body>
</html>

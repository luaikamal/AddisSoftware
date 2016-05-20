<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormViaEntityCodeFirst.aspx.cs" Inherits="EntityCodeFirst.WebFormCodeFirst" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="ObjectDataSource1" Width="293px">
            <Columns>
                <asp:BoundField DataField="Id" HeaderText="Id" SortExpression="Id" />
                <asp:BoundField DataField="Name" HeaderText="Name" SortExpression="Name" />
                <asp:TemplateField HeaderText="Students">
                    <ItemTemplate>
                        <asp:GridView ID="GridView2" runat="server" DataSource='<%# Eval("Students") %>'>
                        </asp:GridView>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="GetCourses" TypeName="EntityCodeFirst.StudentRepository"></asp:ObjectDataSource>
    </div>
    </form>
</body>
</html>

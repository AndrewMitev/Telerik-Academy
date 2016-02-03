<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Employess.aspx.cs" Inherits="Employees.Employess" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="EmployeeID" DataSourceID="SqlDataSource1">
        <Columns>
            <asp:TemplateField HeaderText="Full name">
                <ItemTemplate>
                    <a href="details.aspx?id=<%#: Eval("EmployeeId") %>"><%#: Eval("FirstName") + " " + Eval("LastName") %></a>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
</asp:GridView>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT * FROM [Employees]"></asp:SqlDataSource>
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Showcase.aspx.cs" Inherits="Countries.Showcase" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <asp:ListBox ID="continents" runat="server"
            ItemType="Countries.Models.Continent"
            SelectMethod="GetContinents"
            DataTextField="Name"
            DataValueField="Name">
            <asp:ListItem />
        </asp:ListBox>
    </div>

    <br />
    <asp:GridView ID="grid" runat="server"
        AutoGenerateColumns="False"
        ItemType="Countries.Models.Country" SelectMethod="GetCountries"
        AllowPaging="True" DataSourceID="EntityDataSource1">
    </asp:GridView>

    <asp:EntityDataSource ID="EntityDataSource1" runat="server">
    </asp:EntityDataSource>

    <asp:ListBox ID="ListBox2" runat="server"
        ItemType="Countries.Models.Town"
        SelectMethod="GetTowns"
        DataTextField="Name"
        DataValueField="Name">
        <asp:ListItem />
    </asp:ListBox>
</asp:Content>

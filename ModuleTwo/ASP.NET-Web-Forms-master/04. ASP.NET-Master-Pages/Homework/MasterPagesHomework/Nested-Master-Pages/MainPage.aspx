<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" %>

<asp:Content ID="ContentPage" runat="server"
    ContentPlaceHolderID="ContentPlaceHolderPageContent">
    <h1 id="welcome-text">Welcome to our imaginary company!</h1>
    <asp:HyperLink runat="server" NavigateUrl="~/Bg/BgHome.aspx" 
        Text="Bulgaria" CssClass="bg-icon"/>
    <asp:HyperLink runat="server" NavigateUrl="~/Uk/Home.aspx"
         Text="United Kingdom" CssClass="uk-icon"/>
</asp:Content>

<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="CacheHomework._Default" %>
<%@ Register Src="WelcomeLabel.ascx" TagName="CustomLabel" TagPrefix="uc" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <uc:CustomLabel ID="lbl" runat="server"/>
    
</asp:Content>

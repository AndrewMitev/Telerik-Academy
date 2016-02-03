<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebFormsTest.Calculator" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        First Number:
        <asp:TextBox ID="firstNumber" runat="server"></asp:TextBox>
    </p>
    <p>
        Second Number:
        <asp:TextBox ID="secondNumber" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Sum" Width="113px" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        Result: <asp:TextBox ID="result" runat="server"></asp:TextBox>
    </p>

</asp:Content>

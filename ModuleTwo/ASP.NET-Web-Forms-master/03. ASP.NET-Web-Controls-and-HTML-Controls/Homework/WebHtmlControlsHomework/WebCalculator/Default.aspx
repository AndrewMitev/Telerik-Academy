<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_5.WebCalculator._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <asp:Table ID="TableCalculator" runat="server" BorderStyle="Solid" Width="100px" Height="300px" BorderColor="Black">
        <asp:TableHeaderRow runat="server">
            <asp:TableHeaderCell BorderStyle="Solid" ColumnSpan="4">
                <asp:TextBox ID="textBoxDisplay" ReadOnly="true" runat="server" CssClass="text-right"></asp:TextBox>
            </asp:TableHeaderCell>
        </asp:TableHeaderRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="button1" runat="server" Text="1" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button2" runat="server" Text="2" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button3" runat="server" Text="3" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="buttonPlus" runat="server" Text="+" Width="50px" Height="30px" OnClick="buttonOperation_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="button4" runat="server" Text="4" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button5" runat="server" Text="5" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button6" runat="server" Text="6" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="buttonMinus" runat="server" Text="-" Width="50px" Height="30px" OnClick="buttonOperation_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="button7" runat="server" Text="7" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button8" runat="server" Text="8" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button9" runat="server" Text="9" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="buttonMultiply" runat="server" Text="*" Width="50px" Height="30px" OnClick="buttonOperation_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableRow>
            <asp:TableCell>
                <asp:Button ID="buttonClear" runat="server" Text="Clear" Width="50px" Height="30px" OnClick="buttonClear_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="button0" runat="server" Text="0" Width="50px" Height="30px" OnClick="button_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="buttonDivision" runat="server" Text="/" Width="50px" Height="30px" OnClick="buttonOperation_Click" />
            </asp:TableCell>
            <asp:TableCell>
                <asp:Button ID="buttonSquare" runat="server" Text="√" Width="50px" Height="30px" OnClick="buttonOperation_Click" />
            </asp:TableCell>
        </asp:TableRow>
        <asp:TableFooterRow>
            <asp:TableCell BorderStyle="Solid" ColumnSpan="4">
                <asp:Button ID="buttonEqual" runat="server" Text="=" Width="180px" OnClick="buttonEqual_Click" />
            </asp:TableCell>
        </asp:TableFooterRow>
    </asp:Table>

    <input type="hidden" id="helper" runat="server" name="name" />
    <input type="hidden" id="lastOperation" runat="server" name="nameq" />

</asp:Content>

<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicToe.aspx.cs" Inherits="TicTacToe.TicToe" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .col-md-offset-3 {
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tic Tac Toe</h1>
            <table>
                <tr>
                    <td><asp:Button runat="server" ID="Button1" Height="50px" Width="50px" OnClick="Button_Click" /></td> 
                    <td><asp:Button runat="server" ID="Button2" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                    <td><asp:Button runat="server" ID="Button3" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="Button4" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                    <td><asp:Button runat="server" ID="Button5" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                    <td><asp:Button runat="server" ID="Button6" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                </tr>
                <tr>
                    <td><asp:Button runat="server" ID="Button7" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                    <td><asp:Button runat="server" ID="Button8" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                    <td><asp:Button runat="server" ID="Button9" Height="50px" Width="50px" OnClick="Button_Click" /></td>
                </tr>
            </table>
        </div>
        <p>
            &nbsp;
        </p>
        <p style="margin-left: 520px">
            <asp:Label ID="Span" runat="server" Font-Italic="True" Font-Names="comic-sans" Text="Have fun!"></asp:Label>
        </p>
    </form>
</body>
</html>

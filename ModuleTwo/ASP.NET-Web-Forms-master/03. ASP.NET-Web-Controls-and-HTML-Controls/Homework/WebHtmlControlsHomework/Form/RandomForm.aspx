<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RandomForm.aspx.cs" Inherits="Form.RandomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="textBox" runat="server" />
        <asp:Button ID="buttonBee" runat="server"
            Text="Submit this sh@t!" OnClick="ButtonBee_Click" />
        <div class="row">
            <div class="col-md-5 col-md-offset-2">
                <asp:TextBox ID="showTextBox" runat="server" disabled="disabled" />
            </div>
            <div class="col-md-5">
                <asp:Label ID="showTextLabel" Mode="Encode" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>

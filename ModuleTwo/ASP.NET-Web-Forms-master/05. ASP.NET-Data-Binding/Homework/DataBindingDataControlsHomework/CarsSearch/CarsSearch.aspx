<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CarsSearch.aspx.cs" Inherits="CarsSearch.CarsSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="infoForm" runat="server">
        <div>
            <asp:DropDownList ID="producersDropDown" runat="server"
                AutoPostBack="true" OnSelectedIndexChanged="UpdateModelsList"
                DataTextField="Name" DataValueField="Name">
            </asp:DropDownList>

            <asp:DropDownList ID="modelsDropDown" runat="server"
                DataTextField="Name" DataValueField="Name">
            </asp:DropDownList>
            <div class="row">
                <asp:CheckBoxList RepeatDirection="Horizontal" ID="checkBoxList" runat="server">
                    <asp:ListItem Text="Gazov injekcion" Value="0" />
                    <asp:ListItem Text="El. sedalki" Value="1" />
                    <asp:ListItem Text="Klimatik" Value="2" />
                    <asp:ListItem Text="El. stukla" Value="3" />
                    <asp:ListItem Text="Shibedah" Value="4" />
                    <asp:ListItem Text="ii to stiga .." Value="5" />
                </asp:CheckBoxList>
            </div>
            <asp:RadioButtonList RepeatDirection="Horizontal" ID="radioBoxList" runat="server">
                <asp:ListItem Text="v6" Value="0" />
                <asp:ListItem Text="1.8" Value="1" />
                <asp:ListItem Text="v8" Value="2" />
            </asp:RadioButtonList>
            <asp:Button Text="Filter" runat="server" OnClick="DisplayInfo" />   
        </div>
    </form>
</body>
</html>

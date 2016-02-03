<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Form.aspx.cs" Inherits="StudentsAndCourses.Form" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:TextBox ID="firstName" runat="server" CssClass="form-control" />
        <asp:TextBox ID="lastName" runat="server" CssClass="form-control" />
        <asp:TextBox ID="facultyNumber" runat="server" CssClass="form-control" />
        <asp:DropDownList ID="DropDownListUniversities" runat="server"
            AutoPostBack="True">
            <asp:ListItem Value="Sofia University">Sofia University</asp:ListItem>
            <asp:ListItem Value="Blagoevgrad University">Blagoevgrad University</asp:ListItem>
            <asp:ListItem Value="Pulna parodia">Pulna parodia</asp:ListItem>
            <asp:ListItem Value="Lesotehnicheski">Lesotehnicheski</asp:ListItem>
        </asp:DropDownList>
        <asp:DropDownList ID="DropDownListSpecialties" runat="server"
            AutoPostBack="True">
            <asp:ListItem Value="Gotvartsvo">Gotvartsvo</asp:ListItem>
            <asp:ListItem Value="Magiosnichestvo">Magiosnichestvo</asp:ListItem>
            <asp:ListItem Value="Astrologia">Astrologia</asp:ListItem>
            <asp:ListItem Value="Izvunzemnolog">Izvunzemnolog</asp:ListItem>
        </asp:DropDownList>
        <asp:CheckBoxList ID="Courses" runat="server">
            <asp:ListItem Text="Audio System" Value="Audio System" />
            <asp:ListItem Text="Parktronic" Value="Parktronic"
                Selected="True" />
            <asp:ListItem Text="Cooking & stuff" Value="Cooking & stuff" />
        </asp:CheckBoxList>
        <asp:Button ID="ButtonSubmit" runat="server"
            Text="Submit" OnClick="ButtonSubmit_Click" />
    </form>
</body>
</html>

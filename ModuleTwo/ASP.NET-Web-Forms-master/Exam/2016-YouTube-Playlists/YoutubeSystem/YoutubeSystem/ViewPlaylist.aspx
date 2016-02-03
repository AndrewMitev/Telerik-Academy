<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewPlaylist.aspx.cs" Inherits="YoutubeSystem.ViewPlaylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:FormView runat="server" ID="playlistFormView"
        SelectMethod="playlistFormView_GetItem"
        ItemType="YoutubeSystem.Models.Playlist">
        <ItemTemplate>
            <table cellspacing="0" style="border-collapse: collapse;">
                <tbody>
                    <tr>
                        <td colspan="2">
                            <h2><%#: Item.Title %> <small>Category: <%# Item.Category.Name %></small></h2>
                            <p>
                                <%#: Item.Description %>
                            </p>
                            <p>
                                <span>Author: <%#: Item.Author.FirstName + " " + Item.Author.LastName %></span>
                                <span class="pull-right"><%# Item.DateCreated %></span>
                            </p>
                        </td>
                    </tr>
                    <tr>
                        <td>
                            <small>Videos</small>
                            <asp:Repeater ID="innerRepeater" runat="server"
                                DataSource="<%# Item.Videos %>"
                                ItemType="YoutubeSystem.Models.Video">
                                <ItemTemplate>
                                    <a href="<%#: Item.Url %>">
                                        <br />
                                </ItemTemplate>
                            </asp:Repeater>
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:FormView>
</asp:Content>

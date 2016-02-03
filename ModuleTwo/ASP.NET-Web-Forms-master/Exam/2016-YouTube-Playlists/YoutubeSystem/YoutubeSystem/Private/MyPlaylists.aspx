<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="MyPlaylists.aspx.cs" Inherits="YoutubeSystem.Private.MyPlaylists" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>My Playlists</h1>
    <asp:ListView
        DataKeyNames="Id"
        runat="server"
        ID="myPlaylistsView"
        SelectMethod="myPlaylistsView_GetData"
        ItemType="YoutubeSystem.Models.Playlist"
        DeleteMethod="myPlaylistsView_DeleteItem">
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
                    <tr>
                        <td>
                            <asp:Button CommandName="Delete" Text="Delete Playlist" runat="server" CssClass="btn btn-danger" />
                        </td>
                    </tr>
                </tbody>
            </table>
        </ItemTemplate>
    </asp:ListView>
</asp:Content>

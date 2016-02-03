<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="YoutubeSystem.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>This is home</h1>
    <asp:Repeater
        runat="server"
        ID="playlistsRepeater"
        SelectMethod="playlistsRepeater_GetData"
        ItemType="YoutubeSystem.Models.Playlist">
        <HeaderTemplate>
            <h3>Top 10 playlists</h3>
        </HeaderTemplate>
        <ItemTemplate>
            <div class="row">
                <h3><a href="/ViewPlaylist?id=<%# Item.Id %>"><%# Item.Title %></a></h3>
                <p>
                    <%#: Item.Description %>
                </p>
                <div>
                    <i>by <%#: Item.Author.UserName %></i>
                    <i>created on: <%# Item.DateCreated %></i>
                </div>
            </div>
        </ItemTemplate>
    </asp:Repeater>  
</asp:Content>

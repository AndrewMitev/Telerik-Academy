<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddPlaylist.aspx.cs" Inherits="YoutubeSystem.Private.AddPlaylist" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <asp:ListView ID="addPlaylistView" runat="server"
        ItemType="YoutubeSystem.Models.Playlist"
        SelectMethod="addPlaylistView_GetData"
        InsertMethod="addPlaylistView_InsertItem"
        InsertItemPosition="LastItem">
        <ItemTemplate>
        </ItemTemplate>
        <InsertItemTemplate>
            <div class="form-horizontal">
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Title" CssClass="col-md-2 control-label">Title</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Title" CssClass="form-control" Text="<%# BindItem.Title %>" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Title"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="Title field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Description" CssClass="col-md-2 control-label">Description</asp:Label>
                    <div class="col-md-10">
                        <asp:TextBox runat="server" ID="Description" CssClass="form-control" Text="<%# BindItem.Description %>" />
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="Description"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="Description field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="insertCategory" CssClass="col-md-2 control-label">Category</asp:Label>
                    <div class="col-md-10">
                        <asp:DropDownList
                            ID="insertCategory"
                            runat="server"
                            DataTextField="Name"
                            DataValueField="Id"
                            SelectMethod="insertCategory_GetData"
                            SelectedValue="<%# BindItem.CategoryId %>">
                        </asp:DropDownList>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="insertCategory"
                            CssClass="text-danger" Display="Dynamic" ErrorMessage="Category field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Button Text="Insert" CommandName="Insert" runat="server" CssClass="btn btn-success" />
                    <asp:Button Text="Cancel" runat="server" CssClass="btn btn-danger" />
                </div>
            </div>
        </InsertItemTemplate>
    </asp:ListView>

</asp:Content>

<%@ Page Language="C#" MasterPageFile="../MasterPage.Master" AutoEventWireup="True" CodeBehind="AdminStats.aspx.cs" Inherits="AdminStats" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <h1>Admin Statistics</h1>

    <asp:Label ID="lblTotalVisits" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblRegisteredLogins" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblOnlineUsers" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblRegisteredOnline" runat="server" Text=""></asp:Label><br />
    <asp:Label ID="lblGuestsOnline" runat="server" Text=""></asp:Label>
</asp:Content>


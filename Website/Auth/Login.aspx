<%@ Page Language="C#" MasterPageFile="../MasterPage.Master" AutoEventWireup="True" CodeBehind="Login.aspx.cs" Inherits="Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
  
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div style="font-family: Arial; border: 1px solid #ccc; padding: 20px; width: 300px; margin: 0 auto;">
    <h2>Login</h2>

    <div>
        <label>Username: </label><br />
        <asp:TextBox ID="txtUsername" runat="server" /><br />

        <label>Passowrd: </label><br />
        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" /><br />
    </div>

    <div style="margin-top:10px;">
        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
        <asp:Button ID="btnForgot" runat="server" Text="Forgot Password" OnClick="btnForgot_Click" />
    </div>

    <div style="margin-top:10px;">
        <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
    </div>

    <hr />

    <asp:Label ID="lblStats" runat="server" Font-Size="Small" />
</div>
</asp:Content>

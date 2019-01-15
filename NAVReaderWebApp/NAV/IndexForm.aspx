<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="IndexForm.aspx.cs" Inherits="NAVReaderWebApp.NAV.IndexForm" %>
<asp:Content ID="NAVContent" ContentPlaceHolderID="MainContent" runat="server">
    <br />
    <br />
    <p>Customer count:</p>
    <asp:TextBox ID="TextBoxCount" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:GridView ID="GridViewCust" runat="server"></asp:GridView>
</asp:Content>

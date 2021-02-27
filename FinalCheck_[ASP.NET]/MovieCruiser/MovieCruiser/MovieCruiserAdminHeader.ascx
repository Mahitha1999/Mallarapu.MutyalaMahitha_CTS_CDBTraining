<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="MovieCruiserAdminHeader.ascx.cs" Inherits="MovieCruiser.MovieCruiserAdminHeader" %>
<link href="StyleSheet/StyleSheet.css" rel="stylesheet" />
</style>
<header style="background-color:darkblue;color:whitesmoke;padding:40px; font-size: xx-large;" class="auto-style1">
      Movie Cruiser&nbsp;&nbsp; <asp:Image  ID="Image1" runat="server" Height="44px" Width="34px" ImageUrl="~/Images/movie.jfif" />
 &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:HyperLink ID="HyperLink2" NavigateUrl="~/Login.aspx" runat="server" ForeColor="White">Login</asp:HyperLink>&nbsp;&nbsp;&nbsp;&nbsp;<asp:HyperLink NavigateUrl="~/MovieListAdmin.aspx" ID="HyperLink1" runat="server" ForeColor="White">Movies</asp:HyperLink>
 
</header>
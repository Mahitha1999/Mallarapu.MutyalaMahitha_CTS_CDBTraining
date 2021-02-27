<%@ Page Title="" Language="C#" MasterPageFile="~/MovieCruiser.Master" AutoEventWireup="true" CodeBehind="EditMovie.aspx.cs" Inherits="MovieCruiser.EditMovie" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 1298px;
            margin-left: 180px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
<h1 style="color:darkblue"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Edit Movie </h1>
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;Title: <asp:TextBox ID="TxtTitle" runat="server" Width="679px"></asp:TextBox>
    <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    Gross($)&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Active&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Date of Launch&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Genre <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
    <asp:TextBox ID="TxtGross" runat="server" Width="142px"></asp:TextBox>  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:RadioButton ID="Yes" text="Yes" runat="server" checked/>&nbsp;<asp:RadioButton ID="No" text="No" runat="server" /> &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox ID="TxtDate" runat="server"></asp:TextBox>
    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  <asp:DropDownList ID="Genre" runat="server">
        <asp:ListItem>Superhero</asp:ListItem>
        <asp:ListItem>Science Fiction</asp:ListItem>
        <asp:ListItem>Superhero</asp:ListItem>
        <asp:ListItem>Romance</asp:ListItem>
        <asp:ListItem>Comedy</asp:ListItem>
        <asp:ListItem>Adventure</asp:ListItem>
        <asp:ListItem>Thriller</asp:ListItem>
    </asp:DropDownList>
    <br /> <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;  <asp:CheckBox ID="HasTeaser" text="Has Teaser" runat="server" checked />
      <br />   <br />
  &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;  <asp:Button ID="Button1" runat="server" Text="Save" BackColor="#000099" ForeColor="White" Height="46px" OnClick="Button1_Click" Width="146px" />

  
     <br />
<br />

  
     <br />

 
</asp:Content>

<%@ Page Title="" Language="C#" MasterPageFile="~/MovieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="FavoritesNotification.aspx.cs" Inherits="MovieCruiser.FavoritesNotification" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p style="font-size: 25px; font-weight: bold">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Favorites</p>
   
        <p style="color: #00CC00; text-align: center;">Movie removed from Favorites successfully</p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" CellPadding="10" CellSpacing="10" GridLines="None" HorizontalAlign="Center">
            <Columns>
            <asp:BoundField HeaderText="Id" DataField="Id" ItemStyle-Width="50px" >
            <ItemStyle Width="20px"></ItemStyle>            
             </asp:BoundField>
           
             <asp:BoundField HeaderText="Title" DataField="Title" ItemStyle-Width="50px" >
             <ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
             <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" ItemStyle-Width="50px" >
             <ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
           
              <asp:BoundField HeaderText="Genre" DataField="Genre" ItemStyle-Width="50px" >
              <ItemStyle Width="50px"></ItemStyle>
              </asp:BoundField>
              
             <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\FavoritesNotification.aspx?id={0}"
            Text="Delete"
            HeaderText=" " />

        </Columns>
        </asp:GridView>
    <p style="font-size: 20px; font-weight: bold"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;No. of Favorites: 2</p>

</asp:Content>

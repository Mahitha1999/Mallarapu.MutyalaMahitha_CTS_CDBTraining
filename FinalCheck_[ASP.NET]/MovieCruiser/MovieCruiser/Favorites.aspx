<%@ Page Title="" Language="C#" MasterPageFile="~/MovieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="Favorites.aspx.cs" Inherits="MovieCruiser.Favorites" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            margin-left: 574px;
            margin-top: 50px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2> &nbsp;</h2>
<h2 style="color:darkblue"> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Favorites </h2>
    <asp:panel ID="notification" border="5px dotted green" ForeColor="Green" HorizontalAlign="Center" Visible="false" runat="server" CssClass="auto-style3" Height="63px" Width="387px">
        <br />
        Movie removed from the favorites successfully<br />
        <br />
        <br />
        <br />
        <br /> </asp:panel>
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" BorderStyle="None" GridLines="None" HorizontalAlign="Center" Width="503px" CellPadding="8" >
                  
    <Columns>
           <asp:BoundField HeaderText="ID" DataField="Id" ItemStyle-Width="30px" >
<ItemStyle Width="30px"></ItemStyle>
             </asp:BoundField>
           <asp:BoundField HeaderText="Title" DataField="Title" ItemStyle-Width="100px" >
<ItemStyle Width="100px"></ItemStyle>
             </asp:BoundField>
             <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" ItemStyle-Width="50px" >
<ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
              <asp:BoundField HeaderText="Genre" DataField="Genre" ItemStyle-Width="150px" >
                  <ItemStyle Width="100px"></ItemStyle>
            
             </asp:BoundField>
            
             <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\Favorites.aspx?id={0}&ShowPanel=True"
            Text="Delete"
            HeaderText="Action" ItemStyle-Width="50px">
 

<ItemStyle Width="50px"></ItemStyle>
             </asp:HyperLinkField>
         
       </Columns>
    </asp:GridView>
   <br />
 <p style="font-weight: bold">  <center font-weight="bold" ><h4> Number of Favorites : <asp:Label ID="NoOfFavorites" runat="server" ForeColor="#006600" ></asp:Label> </h4></center> </p> 

</asp:Content>

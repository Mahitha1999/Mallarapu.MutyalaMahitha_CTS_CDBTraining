<%@ Page Title="" Language="C#" MasterPageFile="~/MovieCruiser.Master" AutoEventWireup="true" CodeBehind="MovieListAdmin.aspx.cs" Inherits="MovieCruiser.MovieListAdmin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <h1>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</h1>
<h1 style="color:darkblue">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; Movies</h1> 
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BorderStyle="None" CellPadding="8" GridLines="None" HorizontalAlign="Center" Width="842px" Height="240px" >
         <RowStyle Width="200px" />
        <Columns>
             <asp:BoundField HeaderText="ID" DataField="Id" ItemStyle-Width="50px" >
<ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
           <asp:BoundField HeaderText="Title" DataField="Title" ItemStyle-Width="100px" >
<ItemStyle Width="1000px"></ItemStyle>
             </asp:BoundField>
             <asp:BoundField HeaderText="BoxOffice" DataField="BoxOffice" ItemStyle-Width="50px" >
<ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
           <asp:BoundField HeaderText="Active" DataField="Active" ItemStyle-Width="50px" >
<ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
              <asp:BoundField HeaderText="DateOfLaunch" DataField="DateOfLaunch" ItemStyle-Width="50px" >
<ItemStyle Width="550px"></ItemStyle>
             </asp:BoundField>
              <asp:BoundField HeaderText="Genre" DataField="Genre" ItemStyle-Width="150px" >
                  <ItemStyle Width="500px"></ItemStyle>
             </asp:BoundField>
              <asp:BoundField HeaderText="HasTeaser" DataField="HasTeaser" ItemStyle-Width="50px" >
            
<ItemStyle Width="50px"></ItemStyle>
             </asp:BoundField>
            
             <asp:HyperLinkField
            DataNavigateUrlFields="id"
            DataNavigateUrlFormatString="~\EditMovie.aspx?id={0}"
            Text="Edit"
            HeaderText="Action" />
        </Columns>
    </asp:GridView>
     <asp:LinqDataSource ID="LinqDataSource1" runat="server" EntityTypeName="">
     </asp:LinqDataSource>
</asp:Content>

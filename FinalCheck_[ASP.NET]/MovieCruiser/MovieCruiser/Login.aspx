<%@ Page Title="" Language="C#" MasterPageFile="~/MovieCruiserCustomer.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="MovieCruiser.AdminLogin" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style4 {
            width: 469px;
            height: 336px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
       <br />
   
 
   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp;
   &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; <center> <Div style="border:5px solid darkblue" align="center" class="auto-style4">
      
       <br />
       <br />
      <h2 style="color:darkblue"> Login</h2>
       User Name : <asp:TextBox ID="TxtName" Placeholder="Enter User Name" Width="170px" runat="server" Height="31px"></asp:TextBox> 
       
       <br />
       <br />
       Password&nbsp;  : <asp:TextBox ID="TxtPass"  Placeholder="Enter your Password" runat="server" Width="170px" Height="31px"></asp:TextBox>
      
        <br />
        <br />
<asp:Button style="background-color:darkblue;color:white" ID="Btnclick" runat="server" Text="Login" Height="44px" Width="272px" OnClick="Btnclick_Click"/> 
       
        <br />
        <br />
        <center> <asp:panel ForeColor="Red" id="Msg" visible="false"  runat="Server"> Invalid UserName or Password </asp:panel> </centre>
    
     </Div> 

       </center>
       

    
   
</asp:Content>

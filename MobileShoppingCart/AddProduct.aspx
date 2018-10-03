<%@ Page Title="" Language="C#" MasterPageFile="~/Home.master" AutoEventWireup="true" CodeFile="AddProduct.aspx.cs" Inherits="AddProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <style type="text/css">
        .auto-style6 {
            margin-top: 19px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <br />
    <br />
    <table>
        
        <tr>
            <td>
                
                <asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
             <asp:TextBox ID="txtname" runat="server" Height="34px" Width="204px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Image"></asp:Label>
                <asp:FileUpload ID="FileUpload1" runat="server" BackColor="WhiteSmoke" Height="33px" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Price"></asp:Label>
             <asp:TextBox ID="txtprice" runat="server" BackColor="WhiteSmoke" Height="34px" Width="208px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Description"></asp:Label>
             <asp:TextBox ID="txtdescription" runat="server" Height="99px" Width="175px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label5" runat="server" Text="Category ID"></asp:Label>
             <asp:TextBox ID="txtcategory" runat="server" CssClass="auto-style6" Height="30px" Width="142px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="btnsave" runat="server" Text="ADD PRODUCT" OnClick="Button1_Click" />
            </td>
        </tr>
      
        
    </table>
</asp:Content>


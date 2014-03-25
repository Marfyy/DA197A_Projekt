<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Filmarkiv.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 462px">
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    
        
        <center><asp:TextBox ID="txt_search" runat="server" Width="833px"></asp:TextBox><br />
        <asp:Button ID="btn_search" OnClick="btn_search_Click" runat="server" Text="Search" Width="396px"/><br />
        </center><br /><br /><br /><br />
        <asp:Label ID="lbl_title" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_year" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_rated" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_released" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_runtime" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_genre" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_director" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_writer" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_actors" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_plot" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_language" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_country" runat="server" Text=""></asp:Label>
        <asp:Label ID="lbl_awards" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_metascore" runat="server" Text=""></asp:Label><br />
        <asp:Label ID="lbl_rating" runat="server" Text=""></asp:Label>
        <br />
        <br />
        <asp:Label ID="Youtube" runat="server" Text="Youtube trailer search" Font-Size="Large"></asp:Label><br />
        <asp:Label ID="lbl_youtubeSrc" runat="server" Text=""></asp:Label>
    </div>
    </form>
</body>
</html>

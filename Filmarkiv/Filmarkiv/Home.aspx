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
        
        <asp:Repeater ID="srcListRepeater" runat="server">
            <HeaderTemplate>
                <table border="1" >
                    <tr>
                        <td>Movie</td>
                        <td>Year</td>
                        <td>ID</td>
                    </tr>
            </HeaderTemplate>
            <ItemTemplate>
                <tr>
                    <td><a href="<%# String.Format("./Video.aspx?v={0}", Eval("ID")) %>"><asp:label ID="Label3" Text='<%# Eval("Name") %>' runat="server"></asp:label></a></td>
                    <td><asp:label ID="Label1" Text='<%# Eval("Year") %>' runat="server"></asp:label></td>
                    <td><asp:label ID="Label2" Text='<%# Eval("ID") %>' runat="server"></asp:label></td>
                </tr>

            </ItemTemplate>
            <FooterTemplate></table></FooterTemplate>
        </asp:Repeater>
    </div>
    </form>
</body>
</html>

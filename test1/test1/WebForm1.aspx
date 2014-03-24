<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="test1.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">

    <title></title>
</head>
<body bgcolor="yellow">
    <form id="form1" runat="server">
        <asp:TextBox ID="txtbox1" runat="server"></asp:TextBox>
        <asp:Button ID="btn1" OnClick="btn1_Click" runat="server" Text="Search" />
        <br />
        <asp:TextBox ID="txtbox2" TextMode="MultiLine" runat="server" Height="291px" Width="487px"></asp:TextBox>
    <div>
    </div>
    </form>
</body>
</html>

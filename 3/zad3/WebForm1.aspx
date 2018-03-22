<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="zad3.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="width: 178px; height: 134px">
    
        <a style="width: 76px">Ilość liczb: </a>
        <asp:TextBox ID="TextBox1" runat="server" Width="78px"></asp:TextBox><br /><br />
       
        <a style="width: 76px">Zakres: </a>
        <asp:TextBox ID="TextBox2" runat="server" Width="42px"></asp:TextBox>
        <asp:TextBox ID="TextBox3" runat="server" Width="44px"></asp:TextBox>
    
        <br /><br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Losuj" Width="151px" />
    
    </div>
    </form>
</body>
</html>

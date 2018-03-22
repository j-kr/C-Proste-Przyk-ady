<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Zadanie2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1
        {
            text-align:center;
            background-color:lightgray;
            width: 285px;
            border:solid black 1px;
            padding-top:25px;
        }

       
        .guzki {}

       
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox2" runat="server" Width="260px" Enabled="False"></asp:TextBox>
        <br />
    
        <asp:TextBox ID="TextBox1" runat="server" Width="260px" Enabled="False"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Height="40px" Text="7" Width="40px" OnClick="Button1_Click" CssClass="guzki" />
        <asp:Button ID="Button2" runat="server" Height="40px" Text="8" Width="40px" OnClick="Button2_Click" CssClass="guzki"  />
        <asp:Button ID="Button3" runat="server" Height="40px" Text="9" Width="40px" OnClick="Button3_Click" CssClass="guzki"  />
        <asp:Button ID="Button12" runat="server" Height="40px" Text="+/-" Width="40px" OnClick="Button12_Click" CssClass="guzki"  />
        <asp:Button ID="Button13" runat="server" Height="40px" Text="*" Width="40px" OnClick="Button13_Click"  CssClass="guzki" />
        <asp:Button ID="Button20" runat="server" Height="40px" Text="&lt;--" Width="40px" OnClick="Button20_Click"  CssClass="guzki" />
        <br />
        <asp:Button ID="Button4" runat="server" Height="40px" Text="4" Width="40px" OnClick="Button4_Click" CssClass="guzki"  />
        <asp:Button ID="Button5" runat="server" Height="40px" Text="5" Width="40px" OnClick="Button5_Click"  CssClass="guzki" />
        <asp:Button ID="Button6" runat="server" Height="40px" Text="6" Width="40px" OnClick="Button6_Click"  CssClass="guzki" />
        <asp:Button ID="Button14" runat="server" Height="40px" Text="/" Width="40px" OnClick="Button14_Click"  CssClass="guzki" />
        <asp:Button ID="Button15" runat="server" Height="40px" Text="r" Width="40px" OnClick="Button15_Click"  CssClass="guzki" />
        <asp:Button ID="Button21" runat="server" Height="40px" Text="C" Width="40px" OnClick="Button21_Click"  CssClass="guzki" />
        <br />
       
        <asp:Button ID="Button7" runat="server" Height="40px" Text="1" Width="40px" OnClick="Button7_Click"  CssClass="guzki" />
        <asp:Button ID="Button8" runat="server" Height="40px" Text="2" Width="40px" OnClick="Button8_Click"  CssClass="guzki" />
        <asp:Button ID="Button9" runat="server" Height="40px" Text="3" Width="40px" OnClick="Button9_Click"  CssClass="guzki" />
        <asp:Button ID="Button16" runat="server" Height="40px" Text="-" Width="40px" OnClick="Button16_Click"  CssClass="guzki" />
        <asp:Button ID="Button17" runat="server" Height="40px" Text="1/x" Width="40px" OnClick="Button17_Click"  CssClass="guzki" />
        <asp:Button ID="Button22" runat="server" Height="40px" Text="X^2" Width="40px" OnClick="Button22_Click" CssClass="guzki"  />
       
        <br />
        <asp:Button ID="Button10" runat="server" Height="40px" Text="0" Width="85px" OnClick="Button10_Click" CssClass="guzki"  />
        <asp:Button ID="Button11" runat="server" Height="40px" Text="," Width="40px" CssClass="guzki2" OnClick="Button11_Click" />
        <asp:Button ID="Button18" runat="server" Height="40px" Text="+" Width="40px" OnClick="Button18_Click" CssClass="guzki"  />
        <asp:Button ID="Button19" runat="server" Height="40px" Text="=" Width="85px" OnClick="Button19_Click" CssClass="guzki"  />
        <br />
        <br />
        <br />
    
    </div>
    </form>
</body>
</html>

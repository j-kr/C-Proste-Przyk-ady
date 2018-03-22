<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Zadanie1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
       
         #form1{
            text-align:center;
        }
 
    </style>
</head>
<body>
    
    <form id="form1" runat="server">
        <a>Imie :</a><br /> <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <a>Naziwsko :</a><br /> <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <a>Wiek :</a><br /> <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <a>PESEL :</a><br /> <asp:TextBox ID="TextBox4" runat="server" style="margin-left: 1px"></asp:TextBox>
        <br />
        <a>Kraj :</a><br /> <asp:TextBox ID="TextBox5" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
        <br />
        <a>Miasto :</a><br /> <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <br />
        <a>Ulica :</a><br /> <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
        <br />
        <a>Dom :</a><br /> <asp:TextBox ID="TextBox8" runat="server" style="margin-left: 1px"></asp:TextBox>
        <br />
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Rozmiar Czcionki"></asp:Label><br />
        <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" style="margin-left: 0px" Width="128px">
            <asp:ListItem>12</asp:ListItem>
            <asp:ListItem>14</asp:ListItem>
            <asp:ListItem>16</asp:ListItem>
            <asp:ListItem>18</asp:ListItem>
            <asp:ListItem>20</asp:ListItem>
            <asp:ListItem>22</asp:ListItem>
        </asp:DropDownList>
        <br />
        <asp:Label ID="Label6" runat="server" Text="Krój"></asp:Label><br />
        <asp:DropDownList ID="DropDownList2" runat="server" Height="16px" Width="128px">
            <asp:ListItem Value=" Arial, sans-serif">Arial</asp:ListItem>
            <asp:ListItem Value=" Calibri, sans-serif">Calibri</asp:ListItem>
            <asp:ListItem Value=" Times New Roman, serif">Times</asp:ListItem>
        </asp:DropDownList>
        <br />

        <asp:Label ID="Label7" runat="server" Text="Kolor tła"></asp:Label><br />
        <asp:DropDownList ID="DropDownList3" runat="server" Height="20px" Width="128px" style="margin-left: 0px">
            <asp:ListItem Value="grey">Szare</asp:ListItem>
            <asp:ListItem Value="green">Zielone</asp:ListItem>
            <asp:ListItem Value="red">Czerwone</asp:ListItem>
            <asp:ListItem Value="blue">Niebieskie</asp:ListItem>
        </asp:DropDownList>
        <br />
        <br />
        <br />
        <div style="margin: 0 auto; width: 128px;">
        <asp:Label ID="Label8" runat="server" Text="Dodatkowe"></asp:Label>
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged" style="text-align:center">
            <asp:ListItem Value="bold">Pogrubienie</asp:ListItem>
            <asp:ListItem Value="underline">Podkreślenie</asp:ListItem>
            <asp:ListItem Value="italic">Kursywa</asp:ListItem>
        </asp:CheckBoxList></div>
        <br />
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Wyślij" />
        <br />
    </form>

  
    
</body>
</html>

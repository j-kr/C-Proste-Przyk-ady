<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Zadanie1.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #form1
        {

            width:400px;
            height:250px;
            background-color: <%= Session["tlo"]%>;
            font-size:  <%= Session["rozmiar"]%>px;
            font-family:  <%= Session["kroj"]%>;
            font-weight: <%= Session["pogrobienie"]%>;
            text-decoration: <%= Session["podkresl"]%>;
            font-style: <%= Session["pochyl"]%>;
            text-align:center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 610px">
        <br />
        <asp:Label ID="Label1" runat="server" Text="Imie"></asp:Label> <%= Session["imie"]%> 
        <br />
        <asp:Label ID="Label2" runat="server" Text="Nazwisko"></asp:Label> <%= Session["nazwisko"]%> 
        <br />
        <asp:Label ID="Label3" runat="server" Text="Wiek"></asp:Label> <%= Session["wiek"]%> 
        <br />
        <asp:Label ID="Label4" runat="server" Text="PESEL"></asp:Label> <%= Session["pesel"]%> 
        <br />
        <br />
        <asp:Label ID="Label5" runat="server" Text="Kraj"></asp:Label> <%= Session["kraj"]%> 
        <asp:Label ID="Label6" runat="server" Text="Miasto"></asp:Label>  <%= Session["miasto"]%> 
        <br />
        
        <asp:Label ID="Label7" runat="server" Text="Ulica"></asp:Label> <%= Session["ulica"]%> 
        <br />
        <asp:Label ID="Label8" runat="server" Text="Nr.Domu"></asp:Label> <%= Session["dom"]%> 
        
        <br />
        
        <br />
    </div>
    </form>
</body>
</html>

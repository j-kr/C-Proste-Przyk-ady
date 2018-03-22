<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="zad4.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

    <style type="text/css">
        
        .faktura {
          
            width: 250px;
            height: 400px;
            border: 1px solid black;
            margin: 0 auto;
            margin-left:5px;
            text-align:center;
        }

      
     </style>

</head>
<body>
    <form id="form1" runat="server">
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Wyświetl raport" Width="267px" />
    <div class="faktura">
        <h3>Podsumowanie:</h3><hr />
        
        <h4>Wybrane towary:</h4>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        
        <h4>Sposób dostawy:</h4>
        <asp:Label ID="Label2" runat="server"></asp:Label>

        <h4>Sposób zapłaty:</h4>
        <asp:Label ID="Label3" runat="server"></asp:Label>

    </div>
<br />
<br />
<br />
     <div>
        <h4>Stan magazynu:</h4><hr />
        <asp:Label ID="Label4" runat="server"></asp:Label>

    </div>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Powrót" />
    </form>
</body>
</html>

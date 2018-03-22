<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="zad4.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        
        .t {
            text-align:center;
            width: 19%;
            border: 1px solid black;
            float:left;
            margin-left:5px;
        }

        .butt {
            margin: 10px auto;
            width: 20px;
        }

        .lyst {
            margin: 25px auto;
            width: 200px;
        }

        #form1 {
            height: 604px;
            width: 1343px;
        }

    </style>
</head>
<body style="height: 592px; width: 1339px">
   <form id="form1" runat="server">
    <div class="t">
      <h1>TOWAR 1<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
        </h1>
        <p>Opis opis opis opis opis.</p><br />

        <asp:CheckBox ID="CheckBox1" runat="server" OnCheckedChanged="CheckBox1_CheckedChanged" Text="Wybierz" /><br />

        <asp:DropDownList ID="DropDownList1" runat="server">
        </asp:DropDownList>
    </div>

    <div class="t">
      <h1>TOWAR 2<asp:Label ID="Label4" runat="server" Text="Label"></asp:Label>
        </h1>
        <p>Opis opis opis opis opis.</p><br />

        <asp:CheckBox ID="CheckBox2" runat="server" OnCheckedChanged="CheckBox2_CheckedChanged" Text="Wybierz" /><br />

        <asp:DropDownList ID="DropDownList2" runat="server">
        </asp:DropDownList>
    </div>

    <div class="t">
      <h1>TOWAR 3<asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
        </h1>
        <p>Opis opis opis opis opis.</p><br />

        <asp:CheckBox ID="CheckBox3" runat="server" OnCheckedChanged="CheckBox3_CheckedChanged" Text="Wybierz" /><br />

        <asp:DropDownList ID="DropDownList3" runat="server">
        </asp:DropDownList>
    </div>  

    <div class="t">
      <h1>TOWAR 4<asp:Label ID="Label6" runat="server" Text="Label"></asp:Label>
        </h1>
        <p>Opis opis opis opis opis.</p><br />

        <asp:CheckBox ID="CheckBox4" runat="server" OnCheckedChanged="CheckBox4_CheckedChanged" Text="Wybierz" /><br />

        <asp:DropDownList ID="DropDownList4" runat="server">
        </asp:DropDownList>
    </div>

    <div class="t">
      <h1>TOWAR 5<asp:Label ID="Label7" runat="server" Text="Label"></asp:Label>
        </h1>
        <p>Opis opis opis opis opis.</p><br />

        <asp:CheckBox ID="CheckBox5" runat="server" OnCheckedChanged="CheckBox5_CheckedChanged" Text="Wybierz" /><br />

        <asp:DropDownList ID="DropDownList5" runat="server">
        </asp:DropDownList>
    </div><br />
      
       <div class="lyst" >
           <br />
           <br />
           <br />
           <asp:Label ID="Label1" runat="server" Font-Bold="True" Text="Sposób dostawy:" Visible="False"></asp:Label>
           <br />
           <asp:RadioButtonList ID="RadioButtonList1" runat="server" style="margin-left: 0px" Visible="False" Width="199px" OnSelectedIndexChanged="RadioButtonList1_wybierz">
               <asp:ListItem Value="1">Odbiór Osobisty</asp:ListItem>
               <asp:ListItem Value="2">Dostawa kurierem</asp:ListItem>
               <asp:ListItem Value="3">Odbiór w paczkomacie</asp:ListItem>
           </asp:RadioButtonList>

           <br/>
           <asp:Label ID="Label2" runat="server" Font-Bold="True" Text="Sposób zapłaty:" Visible="False"></asp:Label>
           <br />
           <asp:RadioButtonList ID="RadioButtonList2" runat="server" Visible="False" Width="199px" OnSelectedIndexChanged="RadioButtonList2_wybierz">
               <asp:ListItem Value="1">Przelew bankowy</asp:ListItem>
               <asp:ListItem Value="2">Płatność gotówką</asp:ListItem>
               <asp:ListItem Value="3">Płatność kartą</asp:ListItem>
           </asp:RadioButtonList>
       </div>


       <div class="butt">
       <asp:Button ID="Button2" runat="server" Text="Kup teraz" OnClick="Button2_Click" Visible="False" /> 
       </div>






    </form>
</body>
</html>

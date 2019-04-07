<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        8ВМ82 Бокижнов А. К<p>
            Вопрос:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" Width="120px"></asp:Label>
        </p>
        <p>
            Ваш ответ: 
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Font-Size="12pt" Width="150px"></asp:Label>
        </p>
        <asp:Button ID="Button1" runat="server" Text="Проверить" Width="85px" OnClick="Button1_Click" />
    </form>
</body>
</html>

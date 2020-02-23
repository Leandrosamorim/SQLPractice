<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication6.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table>
            <tr>
                <td>Nome</td>
                <td><asp:TextBox ID="nome" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Sobrenome</td>
                <td><asp:TextBox ID="sobrenome" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Nota 1</td>
                <td><asp:TextBox ID="nota1" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Nota 2</td>
                <td><asp:TextBox ID="nota2" runat="server"></asp:TextBox></td>
            </tr>
             <tr>
                <td>Nota 3 </td>
                <td><asp:TextBox ID="nota3" runat="server"></asp:TextBox></td>
            </tr>
            <tr>
                <td colspan ="2" align="center">
                     <asp:Button ID="Button1" runat="server" Text="Insert" OnClick="Button1_Click" />
                     <asp:Button ID="Button2" runat="server" Text="Delete" OnClick="Button2_Click" />
                     <asp:Button ID="Button3" runat="server" Text="Update" OnClick="Button3_Click" />
                     <asp:Button ID="Button4" runat="server" Text="View" OnClick="Button4_Click" />
                </td>
            </tr>
              <tr>
                <td>Editar por ID</td>
                <td><asp:TextBox ID="editId" runat="server"></asp:TextBox></td>
            </tr>
        </table>

        <br />
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    </form>
</body>
</html>

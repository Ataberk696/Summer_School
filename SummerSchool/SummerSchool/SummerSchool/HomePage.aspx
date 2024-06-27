<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SummerSchool.HomePage" %>

<!DOCTYPE html>
<html>
<head>
    <title>Summer School</title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }

        .auto-style2 {
            background-color: darkgray;
            color: darkgrey;
            padding: 10px 20px;
            border: none;
            border-radius: 5px;
            cursor: pointer;
        }

        .auto-style3 {
            text-align: left;
            height: 50px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">
        <h1>Summer school registration has started!</h1>
        <div>
            <table class="auto-style1">
                <tr>
                    <td>
                        <asp:Image ID="Image1" runat="server" Height="322px" ImageUrl="~/image/Summer-School-1170x658.jpg" Width="1176px" />
                    </td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style3"><strong>
                        <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="46px" OnClick="Button1_Click" Text="Course Page" Width="160px" Font-Bold="True" Font-Names="Arial Black" Font-Overline="False" Font-Strikeout="False" ForeColor="White" />
                    </strong></td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>

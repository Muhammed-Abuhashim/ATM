<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="log-in.aspx.cs" Inherits="ATM.WebForm10" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" rel="stylesheet" />
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            color: #FFFF00;
            font-style: italic;
            font-variant: inherit;
            text-transform: uppercase;
            text-decoration: blink;
            font-family: "Lucida Calligraphy";
            font-weight: 700;
        }
    </style>
</head>
<body>
        <form id="form1" runat="server">
            <p class="loginbox">
                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label Text="USERNAME" CssClass="lblusername" runat="server" ID="Label1" />
                &nbsp; <strong>:</strong>&nbsp;
                <asp:TextBox runat="server" CssClass="txtusername" placeholder="Enter Username" ID="TextBox1" Height="20px" OnTextChanged="Unnamed2_TextChanged" Width="150px" BorderStyle="Double" />
                <br />
                <br />
                <strong>&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label4" runat="server" Height="25px" Width="206px" style="color: #CC0000"></asp:Label>
                </strong>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label Text="PASSWORD" CssClass="lblpassword" runat="server" ID="Label2" />
                &nbsp;<strong>:&nbsp;
                <asp:TextBox runat="server" CssClass="txtusername" placeholder="************" ID="TextBox2" Height="20px" TextMode="Password" Width="150px" BorderStyle="Double" OnTextChanged="TextBox2_TextChanged" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label3" runat="server" Height="25px" Width="206px" style="color: #CC0000"></asp:Label>
&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;
                <asp:Label ID="Label5" runat="server" Height="25px" Width="206px" style="color: #CC0000"></asp:Label>
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button Text="Sign In" CssClass="btnsubmit" runat="server" ID="Button1" Height="40px" OnClick="Button1_Click" Width="180px" BorderStyle="Double" />
                <br />
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button Text="Clear" CssClass="btnsubmit1" runat="server" ID="Button2" Height="40px" OnClick="Button2_Click" Width="180px" BorderStyle="Double" />
                <br />
&nbsp;&nbsp;&nbsp;
                <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
                <asp:Button Text="Cancel" CssClass="btnsubmit2" runat="server" ID="Button3" Height="40px" OnClick="Button3_Click" Width="180px" BorderStyle="Double" />
                <br />
                <br />
                <br />
                <asp:Button Text="Forget Password" CssClass="btnsubmit3" runat="server" ID="Button4" Height="40px" OnClick="Unnamed8_Click" Width="160px" BorderStyle="Double" />
                <br />
                <br />
                <br />
                </strong>
            </p>
        </form>
        <p class="user">
        </p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
            &nbsp;</p>
        <p class="user">
&nbsp;
        </p>
        <p class="user">
&nbsp;&nbsp;&nbsp;
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong>&nbsp;&nbsp;&nbsp;
            <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </strong><span class="auto-style2"><strong>Log In Here</strong></span></span></p>
</body>
</html>

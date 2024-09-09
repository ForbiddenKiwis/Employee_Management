<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebFormApplication.aspx.cs" Inherits="Lab1_ASPNetConnectedMode.GUI.WebFormApplication" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Employee Maintenance</title>
    <style type="text/css">
        #form1 {
            height: 50px;
        }
        .auto-style1 {
            width: 100%;
            height: 735px;
        }
        .auto-style2 {
            text-align: center;
            color: #FF9900;
            font-size: x-large;
        }
        .auto-style3 {
            width: 468px;
            height: 64px;
        }
        .auto-style4 {
            width: 180px;
            height: 64px;
        }
        .auto-style5 {
            width: 180px;
            height: 80px;
        }
        .auto-style6 {
            width: 468px;
            height: 80px;
        }
        .auto-style7 {
            height: 80px;
            width: 259px;
        }
        .auto-style8 {
            width: 378px;
        }
        .auto-style9 {
            height: 80px;
            width: 378px;
        }
        .auto-style10 {
            height: 64px;
            width: 259px;
        }
        .auto-style11 {
            width: 378px;
            height: 64px;
        }
        .auto-style13 {
            width: 259px;
        }
        .auto-style14 {
            height: 47px;
            color: #0000FF;
        }
        .auto-style15 {
            height: 29px;
        }
        .auto-style16 {
            height: 31px;
        }
    </style>
</head>
<body style="height: 496px; width: 1171px">
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2" colspan="3"><strong>Employee Maintenance</strong></td>
                <td class="auto-style13" colspan="2">&nbsp;</td>
                <td class="auto-style8">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Employee ID</td>
                <td class="auto-style6" colspan="2">
                    <%--                    <asp:TextBox ID="EmpId" runat="server" Height="42px" Width="445px" OnTextChanged="EmpId_TextChanged"></asp:TextBox>--%>
                    <asp:TextBox ID="EmpId" runat="server" Height="64px" Width="443px"></asp:TextBox>
                </td>
                <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Save" runat="server" Height="62px" OnClick="Save_Button" Text="Save" Width="185px" ClientIDMode="AutoID" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; First Name</td>
                <td class="auto-style6" colspan="2">
                    <asp:TextBox ID="EmpFirst" runat="server" Height="42px" Width="445px"></asp:TextBox>
                </td>
                <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Update" runat="server" Height="62px" Text="Update" Width="185px" OnClick="Update_Button" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Last Name</td>
                <td class="auto-style6" colspan="2">
                    <%--                    <asp:TextBox ID="EmpLast" runat="server" Height="42px" Width="445px" OnTextChanged="TextBox3_TextChanged"></asp:TextBox>--%>
                    <asp:TextBox ID="EmpLast" runat="server" Height="51px" Width="439px"></asp:TextBox>
                </td>
                <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Delete" runat="server" Height="62px" Text="Delete" Width="185px" OnClick="Delete_Button" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Job Title&nbsp;</td>
                <td class="auto-style6" colspan="2">
                    <%--                    <asp:TextBox ID="EmpJob" runat="server" Height="42px" Width="445px" OnTextChanged="EmpJob_TextChanged"></asp:TextBox>--%>
                    <asp:TextBox ID="EmpJob" runat="server" Height="54px" Width="438px"></asp:TextBox>
                </td>
                <td class="auto-style7" colspan="2">&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="ListAll" runat="server" Height="62px" Text="List All" Width="185px" OnClick="ListAll_Button" />
                </td>
                <td class="auto-style9">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="6" class="auto-style16"></td>
            </tr>
            <tr>
                <td colspan="6" class="auto-style15"></td>
            </tr>
            <tr>
                <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Search By&nbsp;</td>
                <td class="auto-style3" colspan="2">
<%--                    <asp:DropDownList ID="DropDownList1" runat="server" Height="27px" Width="433px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">--%>
                    </asp:DropDownList>
                    <asp:DropDownList ID="DropDownList1" runat="server" Height="16px" Width="436px">
                    </asp:DropDownList>
                </td>
                <td class="auto-style10" colspan="2">
                    <asp:TextBox ID="Search" runat="server" Height="42px" Width="249px"></asp:TextBox>
                </td>
                <td class="auto-style11">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="Button5" runat="server" Height="61px" Text="Search" Width="185px" OnClick="Search_Button" />
                </td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="6"><strong>Employee List</strong></td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2">
                    <asp:GridView ID="GridView1" runat="server">
                    </asp:GridView>
                </td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2"></td>
                <td class="auto-style14" colspan="2"></td>
                <td class="auto-style14" colspan="2"></td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2">&nbsp;</td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14" colspan="2">&nbsp;</td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
                <td class="auto-style14" colspan="2">&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>

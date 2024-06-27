<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="StudentList.aspx.cs" Inherits="SummerSchool.StudentList" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <table class="table table-bordered table-hover">
        <tr>
            <th>Student ID</th>
            <th>Student Name</th>
            <th>Student Surname</th>
            <th>Student Number</th>
            <th>Student Password</th>
            <th>Student Photo</th>
            <th>Wallet</th>
            <th>Operations</th>
        </tr>
        <tbody>
            <asp:Repeater ID="Repeater1" runat="server">
                <ItemTemplate>
                    <tr>
                        <td><%#Eval("ID")%></td>
                        <td><%#Eval("NAME")%></td>
                        <td><%#Eval("SURNAME")%></td>
                        <td><%#Eval("NUMBER")%></td>
                        <td><%#Eval("PASSWORD")%></td>
                        <td><%#Eval("PHOTO")%></td>
                        <td><%#Eval("WALLET")%></td>
                        <td>
                            <asp:HyperLink Navigateurl='<%#"~/DeleteStudent.aspx?STUDENTID="+ Eval("ID")%>' ID="HyperLink1" CssClass="btn btn-danger" runat="server">Delete</asp:HyperLink>
                            <asp:HyperLink Navigateurl='<%#"~/UpdateStudent.aspx?STUDENTID="+ Eval("ID")%>' ID="HyperLink2" CssClass="btn btn-success" runat="server">Update</asp:HyperLink>
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </tbody>

    </table>
</asp:Content>

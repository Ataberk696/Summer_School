﻿<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="UpdateStudent.aspx.cs" Inherits="SummerSchool.UpdateStudent" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="Form1" runat="server">

        <div class="form-group">

            <div>
                <strong>
                    <asp:Label for="TxtId" runat="server" Text="Student Id:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtId" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtName" runat="server" Text="Student Name:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtName" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtSurname" runat="server" Text="Student Surname:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtSurname" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtNumber" runat="server" Text="Student Number:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtNumber" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtPassword" runat="server" Text="Student Password:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPassword" runat="server" CssClass="form-control"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                    <asp:Label for="TxtPhoto" runat="server" Text="Student Photo:"></asp:Label>
                </strong>
                <asp:TextBox ID="TxtPhoto" runat="server" CssClass="form-control"></asp:TextBox>
            </div>

        </div>
        <asp:Button ID="Button1" runat="server" Text="Update" CssClass="btn btn-warning" OnClick="Button1_Click" />
    </form>
</asp:Content>

﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentProfileaspx.aspx.cs" Inherits="fproj.StudentProfileaspx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #form1 {
            width: 1264px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Name:</strong>
            <asp:Label ID="lblFirstName" runat="server"></asp:Label>
            <asp:Label ID="lblLastName" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Pronouns:</strong>
            <asp:Label ID="lblPronouns" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>About Me:</strong>
            <asp:Label ID="lblAboutMe" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <strong>Goals:</strong>
            <asp:Label ID="lblGoals" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            <asp:HyperLink ID="hplEditProfile" runat="server" NavigateUrl="~/StudentEditProfile.aspx" style="text-decoration: underline; font-weight: 700">Edit Profile</asp:HyperLink>
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>

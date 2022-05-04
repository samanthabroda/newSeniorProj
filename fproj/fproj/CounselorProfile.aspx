<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CounselorProfile.aspx.cs" Inherits="fproj.CounselorProfile" %>

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
            Name:
            <asp:Label ID="lblFirstName" runat="server"></asp:Label>
        &nbsp;<asp:Label ID="lblLastName" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Pronouns:
            <asp:Label ID="lblPronouns" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            About Me:
            <asp:Label ID="lblAboutMe" runat="server"></asp:Label>
        </p>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
        <p>
            Experience:
            <asp:Label ID="lblExperience" runat="server"></asp:Label>
        </p>
    </form>
</body>
</html>

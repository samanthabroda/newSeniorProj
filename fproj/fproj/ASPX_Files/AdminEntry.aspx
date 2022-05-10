<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEntry.aspx.cs" Inherits="fproj.AdminEntry" %>

<!DOCTYPE html>

<link href="../CSS/EntryForm.css" rel="Stylesheet" type="text/css" />
<html lang="en">




<body>
    <h1>Add Administrators</h1>
    <div id="container">
		
        
</div>

<div class="allForms">

    <form id="form1" runat="server">
        <label id="formLabel0" for="FirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel6" for="LastName">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />
        Branch:
        <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel2" for="PhoneNumber">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel3" for="PhoneNumber">Phone Number:</label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel4" for="PhoneNumber">Home Address:</label>
        <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel5" for="PhoneNumber">Status:</label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Add Administrator" />
        <br />
        <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
        <br />
        <br />
        
        </form>
        <br>

        <br><br><br>
</div>
        </body> 
</html> 
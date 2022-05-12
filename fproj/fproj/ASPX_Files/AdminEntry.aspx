<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEntry.aspx.cs" Inherits="fproj.AdminEntry" %>

<!DOCTYPE html>

<link href="../CSS/EntryForm.css" rel="Stylesheet" type="text/css" />
<html lang="en">




<body>
    <h1>Add Administrator</h1>
    <div id="container">
		
</div>

<div class="allForms">

    <form id="form1" runat="server">
        <label id="formLabel0" for="FirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br>

        <label class="labels" for="LastName">Last Name:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>
        <br />
        <label class="labels" for="Branch">Branch:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>
        <br />

        <label class="labels" for="PhoneNumber">Email:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>
        <br />

        <label class="labels" for="PhoneNumber">Phone Number:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>
        <br />

        <label class="labels" for="HomeAdress">Home Address:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>
        <br />

        <label class="labels" for="Status">Status:</label>
        <asp:TextBox class="textBoxes" runat="server"></asp:TextBox>

        <br />
        <br />

        <asp:Button class="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Add Administrator" />
        <br />
        <br />
        <br />
        <br />
        
        </form>
        <br>

        <br><br><br>
</div>
        </body> 
</html> 
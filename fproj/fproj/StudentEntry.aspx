<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentEntry.aspx.cs" Inherits="fproj.StudentEntry" %>

<!DOCTYPE html>
<html lang="en">


<body>
    <h1>Add Students</h1>
    <div id="container">
		
        
</div>

<div class="allForms">

    <form id="form1" runat="server">
        <label id="formLabel0" for="FirstName">RAM ID:
        <asp:TextBox ID="txtRamID" runat="server"></asp:TextBox>
        <br />
        First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel6" for="LastName">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel7" for="Email">Major:</label>
        <asp:TextBox ID="txtMajor" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel8" for="PhoneNumber">Standing:</label>
        <asp:TextBox ID="txtStanding" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel1" for="PhoneNumber">Current GPA:</label>
        <asp:TextBox ID="txtCurrentGPA" runat="server"></asp:TextBox>
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
        <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Add Student" />
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


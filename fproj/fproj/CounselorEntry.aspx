<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CounselorEntry.aspx.cs" Inherits="fproj.CounselorEntry" %>

<!DOCTYPE html>
<html lang="en">


<body>
    <h1>Add Counselors</h1>
    <div id="container">
		
        
</div>

<div class="allForms">

    <form id="form1" runat="server">
        <label id="formLabel0" for="FirstName">First Name:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel6" for="LastName">Last Name:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel7" for="Email">Education:</label>
        <asp:TextBox ID="txtEducation" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel8" for="PhoneNumber">Availability:</label>
        <asp:TextBox ID="txtAvailability" runat="server" Rows="6" TextMode="MultiLine"></asp:TextBox>
        <br />

        <label id="formLabel1" for="PhoneNumber">Email:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel3" for="PhoneNumber">Phone Number:</label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel4" for="PhoneNumber">Home Address:</label>
        <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
        <br />
        Department:
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel5" for="PhoneNumber">Status:</label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Add Counselor" />
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


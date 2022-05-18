<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AdminEntry.aspx.cs" Inherits="fproj.AdminEntry" %>

<!DOCTYPE html>

<html>
<head>


<link href="../CSS/EntryForm.css" rel="Stylesheet" type="text/css" />



</head>




<body>
    <h1>Add User</h1>
    <div class="allForms">

        <form id="form1" runat="server">
            <asp:Label ID="lblFill" runat="server"></asp:Label>
            <label id="formLabel0" for="FirstName">
            <br />
        <asp:Label ID="lblMessage" runat="server"></asp:Label>
            <br />
            <br />
            <br />
		
        
       <label id ="userType">Type Of User:</label> <br />
        <asp:RadioButtonList ID="txtUser" runat="server">
            <asp:ListItem>Student</asp:ListItem>
            <asp:ListItem>TLC Member</asp:ListItem>
            <asp:ListItem>Counselor</asp:ListItem>
            <asp:ListItem>Administrator</asp:ListItem>
        </asp:RadioButtonList>
            <br />
            <br />
            <br />
            <label id ="fN">First Name*:</label>
        <asp:TextBox ID="txtFirstName" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel6" for="LastName">Last Name*:</label>
        <asp:TextBox ID="txtLastName" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel2" for="PhoneNumber">Email*:</label>
        <asp:TextBox ID="txtEmail" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel3" for="PhoneNumber">Phone Number*:</label>
        <asp:TextBox ID="txtPhoneNumber" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel4" for="PhoneNumber">Home Address*:</label>
        <asp:TextBox ID="txtHomeAddress" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel5" for="PhoneNumber">Status*:</label>
        <asp:TextBox ID="txtStatus" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <strong>STUDENT AND TLC ENTRY ONLY</strong><br />
        <br />

        <label id="formLabel7" for="Email">Major:</label>
        <asp:TextBox ID="txtMajor" runat="server"></asp:TextBox>
        <br>

        <label id="formLabel8" for="PhoneNumber">Standing:</label>
        <asp:TextBox ID="txtStanding" runat="server"></asp:TextBox>
        <br />

        <label id="formLabel1" for="PhoneNumber">Current GPA:</label>
        <asp:TextBox ID="txtCurrentGPA" runat="server"></asp:TextBox>
        <br />
        <label id="formLabel9" for="FirstName">RAM ID:</label>
        <asp:TextBox ID="txtRamID" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <strong>TLC ENTRY ONLY</strong><br />
        <br />
        <label id="position">Position:</label>
        <asp:TextBox ID="txtPosition" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <strong>COUNSELOR ENTRY ONLY<br />
        </strong>
        <br />

        <label id="formLabel10" for="Email">Education:</label>
        <asp:TextBox ID="txtEducation" runat="server"></asp:TextBox>
        <br> <br />

        <label id="formLabel11" for="PhoneNumber">Availability:</label><br />
        <asp:TextBox ID="txtAvailability" runat="server" Rows="6" TextMode="MultiLine"></asp:TextBox>
        <br />
        <label id="Department">Department:</label>
        <asp:TextBox ID="txtDepartment" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <strong>ADMINISTRATOR ENTRY ONLY</strong><br />
        <br />
        <label id="branch">Branch:</label>
        <asp:TextBox ID="txtBranch" runat="server"></asp:TextBox>
        <br />
        <br />
        <br />
        <br />
        <asp:Button ID="txtSubmit" runat="server" OnClick="txtSubmit_Click" Text="Add User" />
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
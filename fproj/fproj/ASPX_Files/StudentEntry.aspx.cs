using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace fproj
{
    public partial class StudentEntry : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P\SQLEXPRESS; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void txtSubmit_Click(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand cmd = new SqlCommand("insert into STUDENT (RAMID, FirstName, LastName, Major, Standing, CurrentGPA, Email, PhoneNumber, HomeAddress, Status) values('" + txtRamID.Text + "','" + txtFirstName.Text + "','" + txtLastName.Text + "','" + txtMajor.Text + "','" + txtStanding.Text + "','" + txtCurrentGPA.Text + "','" + txtEmail.Text + "','" + txtPhoneNumber.Text + "','" + txtHomeAddress.Text + "','" + txtStatus.Text + "')", c);
            cmd.ExecuteNonQuery();
            lblMessage.Text = "Record submitted successfully!";
            c.Close();
        }
    }
}
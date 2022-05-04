using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace fproj
{
    public partial class CounselorProfile : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P\SQLEXPRESS; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");

        protected void Page_Load(object sender, EventArgs e)
        {
            string first = lblFirstName.Text;
            
            c.Open();
            SqlCommand fname = new SqlCommand("SELECT FirstName FROM COUNSELOR WHERE CounselorID=1", c);
            SqlCommand lname = new SqlCommand("SELECT LastName FROM COUNSELOR WHERE CounselorID=1", c);
            SqlCommand pro = new SqlCommand("SELECT Pronouns FROM COUNSELOR WHERE CounselorID=1", c);
            SqlCommand abme = new SqlCommand("SELECT AboutMe FROM COUNSELOR WHERE CounselorID=1", c);
            SqlCommand exp = new SqlCommand("SELECT Experience FROM COUNSELOR WHERE CounselorID=1", c);


            SqlDataReader fnamereader = fname.ExecuteReader();
            if (fnamereader.Read())
            {
                lblFirstName.Text = fnamereader.GetString(0);
                fnamereader.Close();
            }

            SqlDataReader lnamereader = lname.ExecuteReader();
            if (lnamereader.Read())
            {
                lblLastName.Text = lnamereader.GetString(0);
                lnamereader.Close();
            }

            SqlDataReader abmereader = abme.ExecuteReader();
            if (abmereader.Read())
            {               
                
                lblAboutMe.Text = abmereader.GetString(0);
                abmereader.Close();
            }

            SqlDataReader proreader = pro.ExecuteReader();
            if (proreader.Read())
            {
                lblPronouns.Text = proreader.GetString(0);
                proreader.Close();
            }

            SqlDataReader expreader = exp.ExecuteReader();
            if (expreader.Read())
            {
                lblExperience.Text = expreader.GetString(0);
                expreader.Close();
            }
            c.Close();
        }
    }
}
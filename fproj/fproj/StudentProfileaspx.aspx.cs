﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace fproj
{

    public partial class StudentProfileaspx : System.Web.UI.Page
    {
        SqlConnection c = new SqlConnection(@"Data Source=DESKTOP-DOT3O9P,1434; Initial Catalog=master; User Id=maliksimrah; Password=@Farmingdale123");

        protected void Page_Load(object sender, EventArgs e)
        {
            c.Open();
            SqlCommand fname = new SqlCommand("SELECT FirstName FROM STUDENT WHERE StudentID=2", c);
            SqlCommand lname = new SqlCommand("SELECT LastName FROM STUDENT WHERE StudentID=2", c);
            SqlCommand pro = new SqlCommand("SELECT Pronouns FROM STUDENT WHERE StudentID=2", c);
            SqlCommand abme = new SqlCommand("SELECT AboutMe FROM STUDENT WHERE StudentID=2", c);
            SqlCommand goa = new SqlCommand("SELECT Goals FROM STUDENT WHERE StudentID=2", c);

            SqlDataReader sfnamereader = fname.ExecuteReader();
            if (sfnamereader.Read())
            {
                lblFirstName.Text = sfnamereader.GetString(0);
            }

            sfnamereader.Close();

            SqlDataReader slnamereader = lname.ExecuteReader();
            if (slnamereader.Read())
            {
                lblLastName.Text = slnamereader.GetString(0);
            }

            slnamereader.Close();

            SqlDataReader sabmereader = abme.ExecuteReader();
            if (sabmereader.Read())
            { 
                lblAboutMe.Text = sabmereader.GetString(0);
            }
            sabmereader.Close();

            SqlDataReader sproreader = pro.ExecuteReader();
            if (sproreader.Read())
            {
                lblPronouns.Text = sproreader.GetString(0);
                
            }

            sproreader.Close();

            SqlDataReader sgoareader = goa.ExecuteReader();
            if (sgoareader.Read())
            {
                lblGoals.Text = sgoareader.GetString(0);
                
            }

            sgoareader.Close();

            c.Close();
        }
    }
}
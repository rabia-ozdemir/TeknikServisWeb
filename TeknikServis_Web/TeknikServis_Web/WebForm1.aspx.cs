﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TeknikServis_Web.Entity;

namespace TeknikServis_Web
{
    public partial class WebForm11 : System.Web.UI.Page
    {
        DBTEKNIKSERVISEntities db = new DBTEKNIKSERVISEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            //var degerler = db.TBLURUNTAKIP.ToList();
            //Repeater1.DataSource = degerler;
            //Repeater1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            var degerler = db.TBLURUNTAKIP.Where(x => x.SERINO == TextBox1.Text);
            Repeater1.DataSource = degerler.ToList();
            Repeater1.DataBind();
        }
    }
}
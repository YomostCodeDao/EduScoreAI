﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using QLTHPT1.BusinessLogic;
using QLTHPT1.BusinessObjects;
namespace QLTHPT.UcControl.IndexControls
{
    public partial class chitiettintuc : System.Web.UI.UserControl
    {
        TINTUCBL ttBus = new TINTUCBL();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                LoadTin();
            }
        }

        private void LoadTin()
        {
            int id = int.Parse(Request.QueryString["id"].ToString());
            FormView1.DataSource = ttBus.GetByMaTinTuc(id);
            FormView1.DataBind();
        }
    }
}
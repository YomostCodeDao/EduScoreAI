﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace QLTHPT
{
    public partial class WebForm22 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            switch (Request.QueryString["uc"])
            {
                case "danhgiadiem":
                    PlaceHolder1.Controls.Add(LoadControl("~/UcControl/IndexControls/thongke/danhgiadiemtheomon.ascx"));
                    break;
            }
        }
    }
}
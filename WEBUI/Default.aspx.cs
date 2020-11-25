using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DAL;
using Models;


namespace WEBUI
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           


        }

      

        protected void GridView1_SelectedIndexChanged1(object sender, EventArgs e)
        {
            CarregarItem();

        }


        public void CarregarItem()
        {
            DALItem iDAL = new DALItem();
            GridView1.DataSource = iDAL.ListarItemWeb();
        }
    }
    
}
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.ModelBinding;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Microsoft.AspNet.FriendlyUrls.ModelBinding;
using BookManager.Models;

namespace BookManager.Books
{
    public partial class Details : System.Web.UI.Page
    {
		protected BookManager.Models.ApplicationDbContext _db = new BookManager.Models.ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // This is the Select methd to selects a single Books item with the id
        // USAGE: <asp:FormView SelectMethod="GetItem">
        public BookManager.Models.Books GetItem([FriendlyUrlSegmentsAttribute(0)]int? BookID)
        {
            if (BookID == null)
            {
                return null;
            }

            using (_db)
            {
	            return _db.Books.Where(m => m.BookID == BookID).FirstOrDefault();
            }
        }

        protected void ItemCommand(object sender, FormViewCommandEventArgs e)
        {
            if (e.CommandName.Equals("Cancel", StringComparison.OrdinalIgnoreCase))
            {
                Response.Redirect("../Default");
            }
        }
    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using BookManager.Models;

namespace BookManager.Books
{
    public partial class Default : System.Web.UI.Page
    {
		protected BookManager.Models.ApplicationDbContext _db = new BookManager.Models.ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
        }

        // Model binding method to get List of Books entries
        // USAGE: <asp:ListView SelectMethod="GetData">
        public IQueryable<BookManager.Models.Books> GetData()
        {
            return _db.Books;
        }
    }
}


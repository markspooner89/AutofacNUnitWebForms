using System;
using System.Web.UI;
using Web.Services.Interfaces;

namespace Web.Pages
{
    public partial class Default : Page
    {
        public IPersonService PersonService { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var people = PersonService.GetPeople();

            repPersonRow.DataSource = people;
            repPersonRow.DataBind();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample
{
    public partial class WebForm_LinqToSql : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }


        private void GetPersons()
        {
            var dbContext = new AdventureWorksDataContext();

            var query = (from person in dbContext.Persons
                         where person.FirstName.StartsWith("James")
                         orderby person.FirstName descending
                         select new { person.FirstName, person.LastName, person.MiddleName }).Take(10);

            GridView1.DataSource = query;
            GridView1.DataBind();
        }

        protected void InsertButton_OnClick(object sender, EventArgs e)
        {
            using (var dbContext = new AdventureWorksDataContext())
            {
                var person = new Person
                {
                    BusinessEntityID = 0619223,
                    PersonType = "EM",
                    NameStyle = true,
                    FirstName = "Luai",
                    LastName = "Kamal",
                    EmailPromotion = 1,
                    rowguid = Guid.NewGuid(),
                    ModifiedDate = DateTime.Now
                };
                dbContext.Persons.InsertOnSubmit(person);
                dbContext.SubmitChanges();
            }
            GetPersons();
        }

        protected void UpdateButton_OnClick(object sender, EventArgs e)
        {
            using (var dbContext = new AdventureWorksDataContext())
            {
                var firstOrDefault = dbContext.Persons.FirstOrDefault(x => x.FirstName == "James");
                if (firstOrDefault != null)
                    firstOrDefault.FirstName = "Jamesssssss";
                dbContext.SubmitChanges();
            }
            GetPersons();
        }

        protected void DeleteButton_OnClick(object sender, EventArgs e)
        {
            using (var dbContext = new AdventureWorksDataContext())
            {
                var theJamesssssss = dbContext.Persons.Where(x => x.FirstName == "Jamesssssss").ToList();

                foreach (var jamesssssss in theJamesssssss)
                {
                    dbContext.Persons.DeleteOnSubmit(jamesssssss);
                }
                dbContext.SubmitChanges();

            }
            GetPersons();
        }
    }
}
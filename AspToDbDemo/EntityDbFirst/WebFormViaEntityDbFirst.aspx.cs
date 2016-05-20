using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Sample
{
    public partial class WebFormEntityDbFirst : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        private void DisplayReports()
        {
            //var entities = new DbDemoEntities();
            //GridView1.DataSource = entities.Users;
            //GridView1.DataBind();
        }

        protected void InsertButton_OnClick(object sender, EventArgs e)
        {
            //using (var dbContext = new DemoDbDataClassesDataContext())
            //{
            //    var report = new Report()
            //    { Name = "Test", Description = "---", IsMonthly = true };
            //    dbContext.Reports.InsertOnSubmit(report);
            //    dbContext.SubmitChanges();
            //}
            //DisplayReports();
        }

        protected void UpdateButton_OnClick(object sender, EventArgs e)
        {
            //using (var dbContext = new DemoDbDataClassesDataContext())
            //{
            //    var firstOrDefault = dbContext.Reports.FirstOrDefault(x => x.IsMonthly);
            //    if (firstOrDefault != null)
            //        firstOrDefault.Description = "---" + firstOrDefault.Description;
            //    dbContext.SubmitChanges();
            //}
            //DisplayReports();
        }

        protected void DeleteButton_OnClick(object sender, EventArgs e)
        {
            //using (var dbContext = new DemoDbDataClassesDataContext())
            //{
            //    var reports = dbContext.Reports.Where(x => x.Description.StartsWith("---")).ToList();

            //    foreach (var report in reports)
            //    {
            //        dbContext.Reports.DeleteOnSubmit(report);
            //    }
            //    dbContext.SubmitChanges();
            //}
            //DisplayReports();
        }

        protected void DisplayReports_OnClick(object sender, EventArgs e)
        {
            DisplayReports();
        }
    }
}
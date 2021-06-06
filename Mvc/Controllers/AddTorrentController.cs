using SitefinityWebApp.Mvc.Models;
using System.Web.Mvc;
using Telerik.Sitefinity.Mvc;
using Telerik.Sitefinity.Personalization;
using System;
using Telerik.Sitefinity.DynamicModules;
using Telerik.Sitefinity.Utilities.TypeConverters;

namespace SitefinityWebApp.Mvc.Controllers
{
    [ControllerToolboxItem(Name = "AddTorrent_MVC", Title = "AddTorrent", SectionName = "CustomWidgets")]
    public class AddTorrentController : Controller, IPersonalizable
    {
        public ActionResult Index()
        {
            var model = new AddTorrentModel();
            return View(model);
        }

        public ActionResult Submit(AddTorrentModel model)
        {
            if (ModelState.IsValid)
            {
                DynamicModuleManager dynamicModuleManager = DynamicModuleManager.GetManager();
                Type torrentType = TypeResolutionService.ResolveType("Telerik.Sitefinity.DynamicTypes.Model.Torrent");
                var item = dynamicModuleManager.CreateItem(torrentType);
                dynamicModuleManager.Lifecycle.Publish((Telerik.Sitefinity.Lifecycle.ILifecycleDataItem)item);
                dynamicModuleManager.SaveChanges();
            }

            return View("Index", model);
        }

        protected override void HandleUnknownAction(string actionName)
        {
            this.ActionInvoker.InvokeAction(this.ControllerContext, "Index");
        }

        public string Message { get; set; }
    }
}
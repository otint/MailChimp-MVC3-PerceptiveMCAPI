using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PerceptiveMCAPI;
using PerceptiveMCAPI.Types;
using PerceptiveMCAPI.Methods;

namespace MailChimpAPI.Controllers
{
    public class HomeController : Controller
    {
        string apikey = System.Configuration.ConfigurationManager.AppSettings["apikey"];

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Settings()
        {
            var settings = MCAPISettings.ListAPISettings().ToList();
            return View(settings);
        }

        public ActionResult Lists() 
        {
            listsInput listIn = new listsInput(apikey);
            PerceptiveMCAPI.Methods.lists li = new PerceptiveMCAPI.Methods.lists(listIn);
            listsOutput liOut = li.Execute();

            return View(liOut.result);
        }

        public ActionResult List(string id)
        {
            listMembersInput listIn = new listMembersInput(apikey, id, EnumValues.listMembers_status.subscribed, 0, 100);
            listIn.api_AccessType = EnumValues.AccessType.Serial;
            listIn.api_OutputType = EnumValues.OutputType.JSON;

            listMembers listMem = new listMembers(listIn);
            listMembersOutput listOut = listMem.Execute();

            return View(listOut.result);
        }
    }
}

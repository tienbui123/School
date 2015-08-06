using SchoolWebSerVice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SchoolWebSerVice.Controllers
{
    public class LichThiController : ApiController
    {
        //
        // GET: /LichThi/

        public IEnumerable<LichThi> GetAllLichThi()
        {
            return GetHTML.getLichThi(GetHTML.makeUrlLT("3111410086", "1"));
        }

    }
}

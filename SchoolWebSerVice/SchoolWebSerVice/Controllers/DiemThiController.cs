using SchoolWebSerVice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace SchoolWebSerVice.Controllers
{
    public class DiemThiController : ApiController
    {
        //
        // GET: /DiemThi/

        public DiemThi GetAllDiemThi()
        {
            return GetHTML.getDiemThi(GetHTML.makeUrlDT("3111410089"));
        }

    }
}

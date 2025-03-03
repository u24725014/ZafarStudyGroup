using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ZafarStudyGroup.Models;

namespace ZafarStudyGroup.Controllers
{
    public class StudyGroupController : Controller
    {
        // GET: StudyGroup
        public ActionResult Index()
        {
            var members = new List<StudyGroupMember>
            {
                new StudyGroupMember { Id = 1, StudentNumber = "u01234567", Name = "Jane", Surname = "Doe", Email = "jane.doe@tuks.co.za" },
                new StudyGroupMember { Id = 2, StudentNumber = "u12345678", Name = "John", Surname = "Doe", Email = "john.doe@tuks.co.za" },
                new StudyGroupMember { Id = 3, StudentNumber = "u23456789", Name = "Alice", Surname = "Smith", Email = "alice.smith@tuks.co.za" },
                new StudyGroupMember { Id = 4, StudentNumber = "u34567890", Name = "Bob", Surname = "Johnson", Email = "bob.johnson@tuks.co.za" },
                new StudyGroupMember { Id = 5, StudentNumber = "u45678901", Name = "Charlie", Surname = "Brown", Email = "charlie.brown@tuks.co.za" }
            };
            return View(members);
        }
    }
}
using Buoi03.Models;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace Buoi03.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        const string JSON_FILE = "student.json";
        const string TEXT_FILE = "student.txt";

        static string JsonFullPath => Path.Combine(Directory.GetCurrentDirectory(), "Data", JSON_FILE);

        public IActionResult SaveToFile(StudentInfo sv, string FileType)
        {
            if (FileType == "Save to JSON file")
            {
                var jsonStr = JsonSerializer.Serialize(sv);
                System.IO.File.WriteAllText(JsonFullPath, jsonStr);
            }

            return View("Index", sv);
        }
    }
}

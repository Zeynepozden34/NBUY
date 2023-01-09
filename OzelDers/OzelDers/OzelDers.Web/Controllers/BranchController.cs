using Microsoft.AspNetCore.Mvc;
using OzelDers.Data.Abstract;
using OzelDers.Entity.Concrete;
using OzelDers.Web.Models;

namespace OzelDers.Web.Controllers
{
    public class BranchController : Controller
    {
        private readonly IBranchRepository _branchManager;
        private readonly ITeacherRepository _teacherManager;

        public BranchController(IBranchRepository branchManager, ITeacherRepository teacherManager)
        {
            _branchManager = branchManager;
            _teacherManager = teacherManager;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> GetTeacherByIdBranch(int id)
        {
            var branchs = await _branchManager.GetByIdAsync(id);
            var teachers = await _teacherManager.GetTeacherByIdBranch(id);
            List<TeacherDto> teacherDtos= new List<TeacherDto>();
            foreach (var teacher in teacherDtos)
            {
                teacherDtos.Add(new TeacherDto
                {
                    Id = teacher.Id,
                    UniverstyGraduatedFrom = teacher.UniverstyGraduatedFrom,
                    HourlyPrice = teacher.HourlyPrice,
                    IsFacetoFace = teacher.IsFacetoFace,
                    CertifiedTrainer = teacher.CertifiedTrainer,
                    Email = teacher.Email,
                    Branch = teacher.Branch,
                    FirstName = teacher.FirstName,
                    LastName = teacher.LastName,
                    Description = teacher.Description,
                    Age = teacher.Age,
                    Gender = teacher.Gender,
                    ImageUrl = teacher.ImageUrl,
                    Location = teacher.Location,
                    Url = teacher.Url,
                });
            }
            
                return View();
        }
    }
}

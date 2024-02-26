using DynamicResume.Models;
using DynamicResume;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using DynamicResume.ViewModels;

namespace DynamicResume.Controllers
{
    public class DynamicResumeController : Controller
    {
        private readonly ILogger<DynamicResumeController> _logger;

        private readonly ResumeContext _context;

        public DynamicResumeController(ILogger<DynamicResumeController> logger, ResumeContext context)
        {
            _logger = logger;
            _context = context;
        }



        public IActionResult DynamicResume()
        {
            var projects = _context.DevelopmentProjects.ToList();

            var educations = _context.Education.ToList();

            var employmentHistories = _context.EmploymentHistory.ToList();

            var resumes = _context.Resumes.ToList();

            var viewModel = GetResumeViewModel(projects, educations, employmentHistories, resumes);
            return View(viewModel);
        }

        public IActionResult WorkExperience()
        {
            var employmentHistories = _context.EmploymentHistory.ToList();
            var viewModel = GetEmploymentHistoryViewModel(employmentHistories);
            return View(viewModel);
        }


        private ResumeViewModel GetResumeViewModel(List<DevelopmentProjects> projects, List<Education> educations, List<EmploymentHistory> employmentHistories, List<ResumeData> resumes)
        {
            // Assuming you want to create a single ResumeData object based on the first item in the 'resumes' list
            var resume = resumes.FirstOrDefault();
            if (resume != null)
            {
                resume.DevelopmentProjects = projects;
                resume.Education = educations;
                resume.EmploymentHistory = employmentHistories;
            }

            ResumeViewModel viewModel = new(resume);
            return viewModel;
        }



        private EmploymentHistoryViewModel GetEmploymentHistoryViewModel(List<EmploymentHistory> employments)
        {
            List<EmploymentHistory> employmentHistoryModel = new(employments);
            EmploymentHistoryViewModel viewModel = new(employmentHistoryModel);
            return viewModel;
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}

using Microsoft.AspNetCore.Mvc;
using MVCFarmTask.DAL;
using MVCFarmTask.Models;
using MVCFarmTask.ViewModels;
using static System.Net.WebRequestMethods;

namespace MVCFarmTask.Controllers
{
    public class PageController : Controller
    {

        private readonly AppDbContext _dbContext;

        public PageController(AppDbContext dbcontext)
        {
            _dbContext = dbcontext;
                
        }
        public IActionResult BlogGrid()
        {
            return View();
        }

        public IActionResult BlogDetail()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View();
        }

        public IActionResult TheTeam()
        {
            //Worker worker1 = new Worker
            //{
            //    Fullname = "Keanu Reeves",
            //    Designation = "Field Technician",
            //    Image = "team-1.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};

            //Worker worker2 = new Worker
            //{
            //    Fullname = "Robert De Niro",
            //    Designation = "Farm Mechanic",
            //    Image = "team-2.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};

            //Worker worker3 = new Worker
            //{
            //    Fullname = "Leanorda Dicaprio",
            //    Designation = "Farm Mechanic",
            //    Image = "team-3.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};
            //Worker worker4 = new Worker
            //{
            //    Fullname = "Bradd Pitt",
            //    Designation = "Farmhand",
            //    Image = "team-3.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};
            //Worker worker5 = new Worker
            //{
            //    Fullname = "Keanu Reeves",
            //    Designation = "Field Technician",
            //    Image = "team-1.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};

            //Worker worker6 = new Worker
            //{
            //    Fullname = "Tom Cruise",
            //    Designation = "Farmhand",
            //    Image = "team-2.jpg",
            //    InstagramLink = "www.instagram.com",
            //    FacebookLink = "www.facebook.com",
            //    LinkedinLink = "www.linkedin.com",
            //    XLink = "www.twitter.com"



            //};

            //List<Worker> workers = new List<Worker>() { worker1, worker2, worker3, worker4, worker5, worker6 };
            //_dbContext.Workers.AddRange(workers);
            //_dbContext.SaveChanges();

            List<Worker> workers = _dbContext.Workers.ToList();

            HomeVM homeVM = new HomeVM
            {
                Workers = workers
            };

            return View(homeVM);
        }

        public IActionResult Testimonial()
        {
            return View();
        }

    }
}

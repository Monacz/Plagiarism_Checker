using Microsoft.EntityFrameworkCore;
using Plagiarism_Checker.Models;
using Plagiarism_Checker.Models.Interfaces;
using Plagiarism_Checker.Models.AccountDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using Plagiarism_Checker;
using Moq;
using Plagiarism_Checker.Models;
using Plagiarism_Checker.Controllers;
using System.Linq;
using Plagiarism_Checker.Rpositories;
using Microsoft.AspNetCore.Identity;
using Plagiarism_Checker.Models.Student;
using Plagiarism_Checker.Models.Teacher;
using Microsoft.AspNetCore.Mvc;

namespace plagiarism_checker_testt
{
    public class FakeController<T> where T: BaseEntity
    {




        UserManager<User> userManager = new Mock<UserManager<User>>();
        StudentTasks studentTasks = new Mock<StudentTasks>();
        IRepository<StudentLesson> student_Lesson;
        IRepository<Lesson> lesson;
        IRepository<Plagiarism_Checker.Models.Task> task;
        IRepository<Assignment> assignment;
        IRepository<Solution> solution;
        IRepository<Schedule> schedule;
        IRepository<Discipline> discipline;
        IRepository<Time> time;
        IRepository<Day> day;
        List<Plagiarism_Checker.Models.Student.Subjects> _subjects;
        IRepository<Plagiarism_Checker.Models.Group> group;
        StudentTasks _studentTasks;
        private TeacherTasks teacherTasks;

        [Fact]
        public void TestController1() 
        {
            //arrange
            var mock = new Mock<IRepository<T>>();
            Repository<T> repos = new <T>();
            mock.Setup(repository => repository.GetAll()).Returns(repos.GetAll());
            //act
            var controller = new Plagiarism_Checker.Controllers.TeacherController(userManager, teacherTasks,
            student_Lesson, lesson, task,
             assignment, solution, schedule,
             discipline, time, day, _subjects, group, _studentTasks);
            controller. = Repository<T>;
            var result = controller.Index();
           

            //assert

            var viewResult = Assert.IsType<ViewResult>(result);
            //var model = Assert.IsAssignableFrom <IEnumerable<entities>(viewResult.Model);
            //Assert.Equal(repos.GetAll().Count(), entities.Count())
        }

        

        public class Repository<T> : IRepository<T> where T : BaseEntity
        {
            
            
            
            protected readonly UniverContext context;
            private DbSet<T> entities;
            string errorMessage = string.Empty;

            public IEnumerable<T> GetAll()
            {
                return entities.AsEnumerable();
            }
            public T GetById(int id)
            {
                return entities.SingleOrDefault(s => s.Id == id);
            }
            public void Insert(T entity)
            {
                if (entity == null) throw new ArgumentNullException("entity");

                entities.Add(entity);
                context.SaveChanges();
            }
            public void Update(T entity)
            {
                if (entity == null) throw new ArgumentNullException("entity");
                context.SaveChanges();
            }
            public void Delete(int id)
            {
                if (id == null) throw new ArgumentNullException("entity");

                T entity = entities.SingleOrDefault(s => s.Id == id);
                entities.Remove(entity);
                context.SaveChanges();
            }
        }
    }


using AssessmentApplication.Models;
using AssessmentApplication.Repository;
using AssessmentApplication.Repository.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssessmentApplication.RepositoryImplementation
{
    public class UserTasksRepositoryImplementation : IUserTaskRepository
    {
        private readonly AppDBContext _dbContext;

        public UserTasksRepositoryImplementation(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        public UserTask AddTask(UserTask utask)
        {
            _dbContext.UserTasks.Add(utask);
            _dbContext.SaveChanges();
            return utask;
        }

        public void DeleteTask(int id)
        {
            UserTask utask = GetTasksById(id);
            _dbContext.UserTasks.Remove(utask);
            _dbContext.SaveChanges();
        }

        public List<UserTask> GetAllTasks()
        {
            return _dbContext.UserTasks.ToList();
        }

        public UserTask GetTasksById(int id)
        {
            return _dbContext.UserTasks.FirstOrDefault(x => x.Id == id);
        }

        public void UpdateTask(UserTask utask)
        {
            UserTask uTask1 = new UserTask();
            uTask1.Status = utask.Status;
            uTask1.TaskName = utask.TaskName;
            _dbContext.UserTasks.Update(uTask1);
            _dbContext.SaveChanges();
        }
    }
}

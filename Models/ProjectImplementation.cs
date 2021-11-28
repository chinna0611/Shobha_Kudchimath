namespace Shobha_Kudchimath_Sprint_I.Models
{
    public class ProjectImplementation :IProjectRepository
   {
        private static List<Project> project = new List<Project>();
        private int count = 2;

        public ProjectImplementation()
        {
            project.Add(new Project() { ProjectId = 1, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail", Name = "Project 1" });
            project.Add(new Project() { ProjectId = 2, CreatedOn = DateTime.Now.ToUniversalTime(), Detail = "Task detail2", Name = "Project 2" });
        }

        public Project AddProject(Project projects)
        {
            projects.ProjectId = ++count;
            project.Add(projects);
            return projects;
        }

        public void DeleteProject(int id)
        {
            var result = project.FirstOrDefault(a => a.ProjectId == id);
            var deleted = project.Remove(result);
        }

        public List<Project> GetAllProjects()
        {
            return project;
        }
        public Project GetProjectById(int id)
        {
            return project.FirstOrDefault(e => e.ProjectId == id);
        }

        public void UpdateProject(Project project)
        {
            var data = new Project()
            {
                ProjectId = ++count,
                Name = project.Name,
                CreatedOn = DateTime.Now
            };
        }

    }
}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q3_Assessment07_03_2024
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Employee
    {

    }

    public class Project
    {
        ProjectManager manager =new ProjectManager();
    }
    public class ProjectManager : Employee
    {
        List<Project> projects = new List<Project>();
    }
    public class ProjectLead : Employee
    {
        Project project = new Project();
        ProjectManager manager = new ProjectManager();
    }
}

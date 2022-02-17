using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectManagerTool.Models;

public class ProjectManager
{
    private readonly List<Project> _projects;
    private static ProjectManager? _instance;
    
    private ProjectManager()
    {
        _projects = new List<Project>();
        LoadProjects();
    }

    public static ProjectManager GetProjectManager() => _instance ??= new ProjectManager();

    public List<Project> GetProjects()
    {
        return _projects;
    }

    private void LoadProjects()
    {
        var projectsPath = Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + @"\source\repos");
        foreach (var p in projectsPath)
        {
            Project proj = LoadProjectInfos(p);
            _projects.Add(proj);
        }
    }

    private Project LoadProjectInfos(string path)
    {
        var dirInfos = new DirectoryInfo(path);
        var proj = new Project(path, dirInfos.Name, dirInfos.LastWriteTime);
        return proj;
    }
}
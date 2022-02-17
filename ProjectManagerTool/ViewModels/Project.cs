using System;
using System.Globalization;
using System.Windows.Controls;
using Microsoft.VisualBasic;
using ProjectManagerTool.Models;
using ProjectManagerTool.Views;

namespace ProjectManagerTool.ViewModels;

public class Project
{
    private ProjectManager _porjectManager;
    private MainWindow _mainWindow;

    public Project()
    {
        _porjectManager = ProjectManager.GetProjectManager();
        _mainWindow = new MainWindow();
    }

    public void ShowProjects()
    {
        var projects = _porjectManager.GetProjects();
        foreach (var proj in projects)
        {
            var txt = new TextBox
            {
                Text = proj.GetPath()
            };
            var name = new TextBox
            {
                Text = proj.GetName()
            };
            var date = new TextBox
            {
                Text = Convert.ToString(proj.GetLastUpdate())
            };
            
            _mainWindow.Grid.Children.Add(txt);
            _mainWindow.Grid.Children.Add(name);
            //_mainWindow.Grid.Children.Add(date);
        }
        _mainWindow.Show();
    }
    
    
}
using System;
using System.Data.Common;
using System.IO;

namespace ProjectManagerTool.Models;

public class Project
{
    private readonly string _path;
    private string _name;
    private DateTime _lastUpdateTime;

    public Project(string p, string n, DateTime d)
    {
        this._path = p;
        this._name = n;
        this._lastUpdateTime = d;
    }

    internal string GetPath()
    {
        return this._path;
    }
    internal string GetName()
    {
        return this._name;
    }
    internal void SetName(string name)
    {
        this._name = name;
    }
    
    internal DateTime GetLastUpdate()
    {
        return this._lastUpdateTime;
    }
    internal void SetLastUpdate(DateTime timestamp)
    {
        this._lastUpdateTime = timestamp;
    }
}
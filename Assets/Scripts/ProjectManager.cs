using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using UnityEngine;

public class ProjectManager : MonoBehaviour
{
    [SerializeField] GameObject taskPrefab;

    public ProjectData CurrentProject { get; private set; }


    public void CreateNewProject(string name)
    {
        var proj = new ProjectData
        {
            Guid = Guid.NewGuid().ToString(),
            ProjectName = name,
            Tasks = new List<TaskData>()
        };

        CurrentProject = proj;
    }


    public void SaveProject()
    {
        
    }


    public void LoadProjectFromFile(string path)
    {
        if (!File.Exists(path))
        {
            Debug.LogError($"No such file found at <{path}>");
            return;
        }

        var contents = GetJsonContents(path);
        CurrentProject = LoadProjectFromJson(contents);
    }

    private string GetJsonContents(string path)
    {
        var json = GetDecoded(File.ReadAllBytes(path));
        return json;
    }

    private string GetDecoded(byte[] rawData)
    {
        return Encoding.UTF8.GetString(rawData);
    }

    private byte[] GetEncoded(string json)
    {
        return Encoding.UTF8.GetBytes(json);
    }

    private ProjectData LoadProjectFromJson(string json)
    {
        return JsonConvert.DeserializeObject<ProjectData>(json);
    }
}

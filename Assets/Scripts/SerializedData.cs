using System;
using System.Collections.Generic;
using Newtonsoft.Json;


[Serializable]
public class ProjectData
{
    [JsonProperty]
    public string Guid { get; set; }

    [JsonProperty]
    public string ProjectName { get; set; }

    [JsonProperty]
    public List<TaskData> Tasks { get; set; }
}


[Serializable]
public class TaskData
{
    [JsonProperty]
    public string Guid { get; set; }

    [JsonProperty]
    public string Title { get; set; }

    [JsonProperty]
    public string Description { get; set; }

    [JsonProperty]
    public List<TaskData> ChildTasks { get; set; }
}


using System.IO;
using UnityEngine;

public class FileDataManager : MonoBehaviour
{
    public void Initialize()
    {
        if (!Directory.Exists(GamelyStatics.DefaultProjectDirectory))
        {
            Directory.CreateDirectory(GamelyStatics.DefaultProjectDirectory);
        }
    }
}

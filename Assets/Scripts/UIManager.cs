using System;
using System.IO;
using System.Windows.Forms;
using DG.Tweening;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    #region Left Panel
    [Header("Left Panel")]
    [SerializeField] private RectTransform leftPanelButtonRT;
    [SerializeField] private RectTransform leftPanelRT;

    private bool isLeftPanelOpen;
    public void ToggleLeftPanel()
    {
        leftPanelRT.DOPivotX(isLeftPanelOpen ? 1 : 0, 0.1f);
        isLeftPanelOpen = !isLeftPanelOpen;
    }
    #endregion

    #region New Project
    public void ShowNewProjectDialogue()
    {
        
    }

    public void BrowseForNewProjectFolder()
    {
        var dialog = new System.Windows.Forms.FolderBrowserDialog();
        dialog.RootFolder = Environment.SpecialFolder.UserProfile;
        dialog.ShowNewFolderButton = true;
        dialog.SelectedPath = GamelyStatics.DefaultProjectDirectory;

        var result = dialog.ShowDialog();
        if(result == DialogResult.OK)
            Debug.Log(dialog.SelectedPath);
    }
#endregion
}


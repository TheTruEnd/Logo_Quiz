using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class WinPanel : MonoBehaviour
{
    public Button closeButton;
    public Button restartButton;
    public Button nextStageButton;
    private void OnEnable()
    {   
        closeButton.onClick.AddListener(ClosePanel);
        restartButton.onClick.AddListener(ReStartStage);
        nextStageButton.onClick.AddListener(LoadNextStage);
    }
    private void OnDisable()
    {   
        closeButton.onClick.RemoveAllListeners();
        restartButton.onClick.RemoveAllListeners();
        nextStageButton.onClick.RemoveAllListeners();
    }

    private void ReStartStage()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    private void ClosePanel()
    {
        gameObject.SetActive(false);
    }

    private void LoadNextStage()
    {
        
    }
}

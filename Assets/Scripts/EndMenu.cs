using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EndMenu : MonoBehaviour
{
    public GameObject quit;
    private Button quitButton;

    void Start()
    {
        quitButton = quit.GetComponent<Button>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            QuitApp();
        }
    }

    public void QuitApp()
    {
        #if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
        #endif
            Application.Quit();
    }

    public void PlayAgain()
    {
        SceneManager.LoadScene("Level 1");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndMenu : MonoBehaviour
{
    public GameObject quit;
    private Button quitButton;

    void Start()
    {
        quitButton = quit.GetComponent<Button>();
    }

    /*public void Quit()
    {
         Application.Quit();
    }*/
    void Update()
    {
        //if ((Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl)) && Input.GetKeyDown(KeyCode.Q))
        //{
        //    quitButton.onClick.Invoke();
        //}
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
}

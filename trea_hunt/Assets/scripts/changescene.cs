using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene : MonoBehaviour
{
    public void LoadInstScene()
    {
        SceneManager.LoadScene("inst_scene");
    }
    public void ExitApp()
    {
        Application.Quit();
        Debug.Log("You have quit the app");
    }
    public void loadmenuscene()
    {
        SceneManager.LoadScene(2);
    }
}

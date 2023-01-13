using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class changescene_mainmenu : MonoBehaviour
{
    public void LoadInstScene()
    {
        SceneManager.LoadScene("inst_scene");
    }
    public void loadmenuscene()
    {
        SceneManager.LoadScene(0);
    }
}

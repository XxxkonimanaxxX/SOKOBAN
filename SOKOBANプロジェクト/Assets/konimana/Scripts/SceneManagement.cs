using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManagement : MonoBehaviour
{
    public void ToTitle()
    {
        SceneManager.LoadScene("Title");
    }
    public void ToMain()
    {
        SceneManager.LoadScene("Main");
    }
    public void SceneReload()
    {
        SceneManager.LoadScene("Main");
    }
    public void ToDesktop()
    {
        Application.Quit();
    }
}

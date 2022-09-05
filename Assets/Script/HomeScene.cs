using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScene : MonoBehaviour
{
    public void OpenGameplay()
    {
        SceneManager.LoadScene("Gameplay");
    }
    public void OpenTheme()
    {
        SceneManager.LoadScene("Theme");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
  public void LoadSinglePlayer()
    {
        SceneManager.LoadScene(1);
    }

    public void LoadCoop()
    {
        SceneManager.LoadScene(2);
    }
}

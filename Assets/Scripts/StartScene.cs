using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScene : MonoBehaviour
{
   public void OnClickLoadScene()
  {
    SceneManager.LoadScene("Game");
  }

  public void OnClickGameOver()
  {
    SceneManager.LoadScene("Game");
  }
  public void OnClickStartMenu()
  {
    SceneManager.LoadScene(0);
  }
  public void QuitGame()
  {
    Application.Quit();
  }
}

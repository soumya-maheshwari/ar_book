using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class mainMenu : MonoBehaviour
{

   // load scene
   public void Play()
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
   public void Back()
   {
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }

   // quit
   public void Quit()
   {
      Application.Quit();
      Debug.Log("Player has quit the app");
   }

   public void About()
   {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }
}

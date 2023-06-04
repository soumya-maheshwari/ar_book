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
          SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
   public void SubjectBack()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
   }
    public void AnimalBack()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
   }
    public void Animal()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   } 
     public void Plant()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
   }
     public void PublicBack()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
   }
     public void Human()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
   }
     public void HumanBack()
   {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);
   }
      public void Quit()
   {
      Application.Quit();
      Debug.Log("Player has quit the app");
   }

   public void About()
   {
         SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
   }

   public void Tiger()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);  
   }
    public void Spider()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);  
   }
    public void SpiderBack()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 5);  
   }
     public void TigerBack()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);  
   }
      public void Brain()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);  
   }
      public void BrainBack()
   {
      SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 4);  
   }
   }

 
  

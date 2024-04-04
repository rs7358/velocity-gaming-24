using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
//    public void RaceNow(){
//     SceneManager.LoadScene(3);
//    }
   public void RaceNow(){
    SceneManager.LoadScene(2);
   }
   public void GameMenu(){
    SceneManager.LoadScene(1);
   }

   public void Track01(){
    SceneManager.LoadScene(3);
   }

   public void Track02(){
    SceneManager.LoadScene(2);
   }

}

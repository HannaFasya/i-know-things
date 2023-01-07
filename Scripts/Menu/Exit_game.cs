using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exit_game : MonoBehaviour
{
   public void QuitGame()
   {
    Application.Quit();
    Debug.Log("Yahh keluar game :( !");
   }
}

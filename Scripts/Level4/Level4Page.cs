using UnityEngine;
using UnityEngine.SceneManagement;

public class Level4Page : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}

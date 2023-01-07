using UnityEngine;
using UnityEngine.SceneManagement;

public class Level2Page : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}

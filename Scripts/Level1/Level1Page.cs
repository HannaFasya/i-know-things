using UnityEngine;
using UnityEngine.SceneManagement;

public class Level1Page : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}

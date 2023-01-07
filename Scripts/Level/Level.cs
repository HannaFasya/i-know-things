using UnityEngine;
using UnityEngine.SceneManagement;

public class Level : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}

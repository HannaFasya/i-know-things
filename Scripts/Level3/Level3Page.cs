using UnityEngine;
using UnityEngine.SceneManagement;

public class Level3Page : MonoBehaviour
{
   public void ChangeScene(string sceneName)
   {
       SceneManager.LoadScene(sceneName);
   }
}

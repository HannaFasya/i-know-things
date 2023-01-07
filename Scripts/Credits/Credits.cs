using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void ChangeScene(string Menu)
   {
       SceneManager.LoadScene(Menu);
   }
}

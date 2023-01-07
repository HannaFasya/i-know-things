using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class SceneLoader2 : MonoBehaviour
{
    public GameObject LoaderUI;
    public Slider progressSlider;
 
    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine2(index));
    }
 
    public IEnumerator LoadScene_Coroutine2(int index)
    {
        progressSlider.value = 0;
        LoaderUI.SetActive(true);
 
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(8);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
 
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 8;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
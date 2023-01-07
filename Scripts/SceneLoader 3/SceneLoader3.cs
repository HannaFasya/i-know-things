using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
 
public class SceneLoader3 : MonoBehaviour
{
    public GameObject LoaderUI;
    public Slider progressSlider;
 
    public void LoadScene(int index)
    {
        StartCoroutine(LoadScene_Coroutine3(index));
    }
 
    public IEnumerator LoadScene_Coroutine3(int index)
    {
        progressSlider.value = 0;
        LoaderUI.SetActive(true);
 
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(10);
        asyncOperation.allowSceneActivation = false;
        float progress = 0;
 
        while (!asyncOperation.isDone)
        {
            progress = Mathf.MoveTowards(progress, asyncOperation.progress, Time.deltaTime);
            progressSlider.value = progress;
            if (progress >= 0.9f)
            {
                progressSlider.value = 10;
                asyncOperation.allowSceneActivation = true;
            }
            yield return null;
        }
    }
}
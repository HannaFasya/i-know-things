using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver1Screen : MonoBehaviour
{
   public Text scoreText;

   public void Setup(int score)
   {
    gameObject.SetActive(true);
   //  scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
    scoreText.text = score.ToString() + " POINTS";
   }

   public void RestartButton()
   {
      SceneManager.LoadScene("Level");
   }

   public void ExitButton()
   {
      SceneManager.LoadScene("Menu");
   }
}

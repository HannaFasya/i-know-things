using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BasketScore : MonoBehaviour
{
    public Text scoreText;
    public int score = 0;
    AudioSource audio;
    public AudioClip hitSound;

    void Start()
    {
        audio = GetComponent<AudioSource>();
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }

    void Update()
    {
        if (score >= 100) {
            StartCoroutine(GameOver(score));
        }
    }

    void OnTriggerEnter2D(Collider2D target)
    {
        audio.PlayOneShot(hitSound);
        if (target.tag == "Benar")
        {
            target.gameObject.SetActive(false);
            score += 10;
            scoreText.text = score.ToString();
        }
        else if (target.tag == "Salah")
        {
            transform.position = new Vector2(0, 100);
            target.gameObject.SetActive(false);
            StartCoroutine(GameOver(score)); 
        }
    }


    IEnumerator GameOver(int points) 
    {
        yield return new WaitForSecondsRealtime(2f);
        // SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        switch(points) {
            case 0:
                SceneManager.LoadScene("GameOverScore0");
                break;
            case 10:
                SceneManager.LoadScene("GameOverScore10");
                break;
            case 20:
                SceneManager.LoadScene("GameOverScore20");
                break;
            case 30:
                SceneManager.LoadScene("GameOverScore30");
                break;
            case 40:
                SceneManager.LoadScene("GameOverScore40");
                break;
            case 50:
                SceneManager.LoadScene("GameOverScore50");
                break;
            case 60:
                SceneManager.LoadScene("GameOverScore60");
                break;
            case 70:
                SceneManager.LoadScene("GameOverScore70");
                break;
            case 80:
                SceneManager.LoadScene("GameOverScore80");
                break;
            case 90:
                SceneManager.LoadScene("GameOverScore90");
                break;
            case 100:
                SceneManager.LoadScene("GameOverScore100");
                break;
        }
       
        //coba-coba
        // scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        // scoreText.text = score.ToString() + " POINTS";
    }
}

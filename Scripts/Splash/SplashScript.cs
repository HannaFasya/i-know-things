using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SplashScript : MonoBehaviour {


	public float time = 3; //Seconds to read the text

	IEnumerator Start ()
	{
		yield return new WaitForSeconds(time);
        SceneManager.LoadScene("Menu");
        // Destroy(gameObject);
	}
}
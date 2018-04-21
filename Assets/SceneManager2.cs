using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		if (SceneManager.GetActiveScene ().name == "EndGame") {
			if (Input.GetButton ("Fire3")) {
				SceneManager.LoadScene ("MainMenu");
			}

			if (Input.GetButton ("Fire1")) {
				SceneManager.LoadScene ("MainMenu");
			}

			if (Input.GetButton ("Jump")) {
				SceneManager.LoadScene ("MainMenu");
			}
		}

		if (SceneManager.GetActiveScene ().name == "MainMenu") {
			if (Input.GetButton ("Fire3")) {
				SceneManager.LoadScene ("Scene_01");
			}

			if (Input.GetButton ("Fire1")) {
				SceneManager.LoadScene ("Instructions");
			}

			if (Input.GetButton ("Jump")) {
				Application.Quit ();
			}
		}

        if (SceneManager.GetActiveScene().name == "Instructions")
        {
            
            if (Input.GetButton("Jump"))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }

        if (SceneManager.GetActiveScene().name == "WinScreen")
        {

            if (Input.GetButton("Fire1"))
            {
                SceneManager.LoadScene("MainMenu");
            }
        }
    }
}

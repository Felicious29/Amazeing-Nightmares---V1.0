using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class activateLever : MonoBehaviour
{
    public Animator anim;
    public AudioSource[] audioSrcs;

	// Use this for initialization
	void Start ()
    {
        anim.GetComponent<Animator>();
        audioSrcs[0].GetComponent<AudioSource>();
        //audioSrcs[1].GetComponent<AudioSource>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        /*if (Input.GetKeyDown("f"))
        {
            anim.enabled = true;
            audioSrcs[0].PlayDelayed(0.2f);
            audioSrcs[1].PlayDelayed(2.0f);
			SceneManager.LoadScene("Scene_02");
        }*/
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //&& Input.GetKeyDown("f"))
        {
            anim.enabled = true;
            audioSrcs[0].PlayDelayed(0.2f);
            audioSrcs[1].PlayDelayed(2.0f);
            //SceneManager.LoadScene("Scene_02");
            Debug.Log("lol");
        }
    }
}

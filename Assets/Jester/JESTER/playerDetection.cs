using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDetection : MonoBehaviour
{
	static Animator enemyAnim;
    EnemyPatrol patrolRef;
    public AudioSource[] audioSrcs;

    // Use this for initialization
    void Start ()
    {
        enemyAnim = GetComponent<Animator>();
        patrolRef = GetComponent<EnemyPatrol>();
        audioSrcs[0].GetComponent<AudioSource>();
    }

	// Update is called once per frame
	void Update ()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") 
        {
            enemyAnim.SetTrigger("isRunning");
            audioSrcs[0].Play();
            patrolRef.speed = 5.0f;
            Vector3.MoveTowards(transform.position, other.transform.position, 0.5f);

			Invoke ("playerDead", 2);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
			enemyAnim.SetTrigger("isWalking");
			patrolRef.speed = 3.0f;
        }
    }

	void playerDead()
	{
		SceneManager.LoadScene("EndGame");
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerDetection : MonoBehaviour
{

    public bool inRange = false;
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
            enemyAnim.SetBool("inRange", true);
            enemyAnim.SetBool("isWalking", false);
            audioSrcs[0].Play();
            patrolRef.speed = 5.0f;
            Vector3.MoveTowards(transform.position, other.transform.position, 0.5f);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            patrolRef.speed = 3.0f;
            enemyAnim.SetBool("isWalking", true);
            enemyAnim.SetBool("inRange", false);
        }
    }
}

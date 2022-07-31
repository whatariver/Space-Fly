using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Animator animator;
    public bool deadcheck = false;
    public AudioSource explosion;
    public GameObject ScoreBoard;
    // Start is called before the first frame update
    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
    }
    void OnTriggerEnter2D (Collider2D col)
    {
        
        deadcheck = true;
        animator.SetTrigger("expl");
        explosion.Play();
        Destroy(this.gameObject,0.6f);
        ScoreBoard.SetActive(false);
    }

   
}

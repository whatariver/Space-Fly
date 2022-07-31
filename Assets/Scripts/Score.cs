using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    public GameObject ScoreBoard;
    public GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        ScoreBoard = GameObject.FindGameObjectWithTag("Board");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < player.transform.position.y)
        {
            ScoreBoard.GetComponent<ScoreBoard>().Score += 1;
            Destroy(this);
        }
        if (player.GetComponent<PlayerScript>().deadcheck == true)
        {
            Destroy(this);
        }

    }




}

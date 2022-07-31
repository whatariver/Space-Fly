using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundLoad : MonoBehaviour
{
    public GameObject player;
    public float speed = -2f;

    void Update()
    {
        if (player != null)
        {
            speed -= 0.25f*Time.deltaTime;
            

            if (player.GetComponent<PlayerScript>().deadcheck == false)
            {

                transform.position += new Vector3(0, speed * Time.deltaTime);
                if (transform.position.y < -20)
                {
                    transform.position = new Vector3(-17, 87, 0);
                }
            }

        }
        if (player.GetComponent<PlayerScript>().deadcheck == true)
        {
            speed = -2f;

            transform.position += new Vector3(0, speed * Time.deltaTime);
            Destroy(this,0.6f);
        }
    }
}

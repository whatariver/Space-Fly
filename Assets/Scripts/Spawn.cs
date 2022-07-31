using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public Transform[] allitems;
    private int whichitem;
    private float xPos;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawntimer());
    }

    IEnumerator spawntimer()
    {

        yield return new WaitForSeconds(1);
        whichitem = Random.Range(0, 4);
        xPos = Random.Range(-200, 400) / 100f;

         
        Transform background = GameObject.FindGameObjectWithTag("Background").transform;
        Transform background2 = GameObject.FindGameObjectWithTag("Background2").transform;

        if (background.position.y > -4.5f)
            Instantiate(allitems[whichitem], new Vector3(xPos, 6, 0), allitems[whichitem].rotation,background);
        else
            Instantiate(allitems[whichitem], new Vector3(xPos, 6, 0), allitems[whichitem].rotation, background2);
        StartCoroutine(spawntimer());
    }
}

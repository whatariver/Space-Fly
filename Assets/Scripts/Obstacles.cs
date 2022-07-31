using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    public float positionY;

    // Update is called once per frame
    void Update()
    {
        positionY = transform.position.y;

        if (positionY < -8f) 
        { 
            Destroy(this.gameObject);

        }
        
    }
}

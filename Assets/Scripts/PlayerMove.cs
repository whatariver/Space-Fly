using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Touch touch;
    private float speedModifier;
    // Start is called before the first frame update
    void Start()
    {
        speedModifier = 0.005f;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.touchCount >0)
        {
            touch = Input.GetTouch(0);

            if (touch.phase == TouchPhase.Moved)
            {
                transform.position = new Vector2(transform.position.x + touch.deltaPosition.x * speedModifier, transform.position.y + touch.deltaPosition.y * speedModifier);
            }
        }

        if (transform.position.x <= -1)
            transform.position = new Vector2(-1f, transform.position.y);
        if (transform.position.x >= 3.5)
            transform.position = new Vector2(3.5f, transform.position.y);
    }
}

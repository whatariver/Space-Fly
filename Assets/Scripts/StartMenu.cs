using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartMenu : MonoBehaviour
{
    public GameObject background2;
    public GameObject background;
    public GameObject scoreBoard;
    public GameObject spawner;
    // Start is called before the first frame update
    void Start()
    {
        background = GameObject.FindGameObjectWithTag("Background");
        background2 = GameObject.FindGameObjectWithTag("Background2");
    }

    // Update is called once per frame
    void Update()
    {
        background.GetComponent<BackgroundLoad>().speed = -2f;
        background2.GetComponent<BackgroundLoad>().speed = -2f;
    }

    public void Startgame()
    {
        background.GetComponent<BackgroundLoad>().speed = -3.5f;
        background2.GetComponent<BackgroundLoad>().speed = -3.5f;
        scoreBoard.SetActive(true);
        spawner.SetActive(true);
        Destroy(this.gameObject);
    }
    public void Quit()
    {
        Application.Quit();
    }


}

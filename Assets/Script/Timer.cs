using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    public Text p1TimerText;
    public Text p2TimerText;


    public GameObject[] panels;
    private float timer= 250f;
    

    void Start()
    {
        p1TimerText = GetComponent<Text>();
        p2TimerText = GetComponent<Text>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
         timer -= Time.deltaTime;


        p1TimerText.text = timer.ToString("f2");
        p2TimerText.text = timer.ToString("f2");
        if (timer <= 0)
        {
            //Display message or pop for restart game
            timer = Time.deltaTime;
            
        }
    }
    void GameRestart()
    {
        
    }
}

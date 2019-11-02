using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VegSpawnRandom : MonoBehaviour
{
    // Start is called before the first frame update

    private int rand;

    public Sprite[] Sprites_Pic;

    void Start()
    {
        rand = Random.Range(1, Sprites_Pic.Length);
        GetComponent<SpriteRenderer>().sprite = Sprites_Pic[rand];

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

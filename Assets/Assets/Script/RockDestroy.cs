using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockDestroy : MonoBehaviour
{
    public int rock = 8;

    void Update()
    {
        if (rock <= 0)
        {
            Destroy(gameObject);
            Score.score += 5;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            rock = rock - 1;
            
        }
    }

}

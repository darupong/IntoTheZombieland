using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BluezombieHP : MonoBehaviour
{
    public int bzombie = 1;

    void Update()
    {
        if (bzombie <= 0)
        {
            Destroy(gameObject);
            Score.score += 20;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            bzombie = bzombie - 1;
            
        }
        if (other.gameObject.tag == "Player")
        {
            Destroy(gameObject);
            Score.timeLeft -= 5;
        }
    }
}

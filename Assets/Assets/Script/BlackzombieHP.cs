using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackzombieHP : MonoBehaviour
{
    public int bzombie = 15;

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
            Score.timeLeft -= 3;
        }
    }
}

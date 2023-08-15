using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HPEnemy : MonoBehaviour
{
    public int zombie = 3;

    void Update()
    {
        if (zombie <= 0)
        {
            Destroy(gameObject);
            Score.score += 10;
        }

    }

    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            zombie = zombie - 1;
        }
    }
}

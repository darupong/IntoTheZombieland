using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletDestroy : MonoBehaviour
{
    public GameObject gameobb;

    void OnCollisionEnter2D(Collision2D other)
    {
        Destroy(gameobb);
        Debug.Log("Dooon");
    }
}

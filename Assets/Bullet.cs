using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float despawnTime;
    void Start()
    {
        Destroy(gameObject, despawnTime);
    }
        
    private void OnCollisionEnter2D(Collision2D collsion)
    {
        Destroy(gameObject);
    }
}

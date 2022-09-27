using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public float speed;
    public float destroyTime;
    void Start()
    {
        Invoke("DestroyAmmo", destroyTime);
    }

    
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);
    }
    void DestoyBullet()
    { 
     Destroy(gameObject);
    }
    
}

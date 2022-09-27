using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TargetWeapon : MonoBehaviour


{
    public float offset;
    public GameObject ammo;
    public Transform shotDir;
    private float timeShot;
    public float startTime;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { // вроде работает только по оси Z ? 
        Vector3 diffence = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        float rotateZ = Mathf.Atan2(diffence.x, diffence.y) * Mathf.Rad2Deg;
        float rotateX = Mathf.Atan2(diffence.y, diffence.z) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(rotateX + offset, 0f, rotateZ + offset);
        //transform.rotation = Quaternion.Euler(0f, 0f, 0f);


        if (timeShot <= 0)
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(ammo, shotDir.position, transform.rotation);
                timeShot = startTime;
            }
            else
            {
             timeShot -= Time.deltaTime;
            }
        }

        // выстрел 
       
    }
}


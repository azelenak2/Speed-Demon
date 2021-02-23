using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class shoot : MonoBehaviour
{
    public GameObject projectile;
    float fire;
    float firecool;

    // Start is called before the first frame update
    void Start()
    {
        firecool = 1f;
        fire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        FireCoolDown(); 
    }
    void FireCoolDown()
    {
        if (Time.time > fire)
        {
            Instantiate(projectile, transform.position, Quaternion.identity);
            fire = Time.time + firecool;
        }
    }
}

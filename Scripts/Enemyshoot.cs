using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemyshoot : MonoBehaviour
{
    public GameObject projectile;
    public Transform Enemy;
    public int waitingTime;
    float timer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > waitingTime)
        {
            shootBullet();
            timer = 0;
        }
    }
        public void shootBullet()
        {
            GameObject b = Instantiate(projectile) as GameObject;
            b.transform.position = Enemy.transform.position;
        }
    
}

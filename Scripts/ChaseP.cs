using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaseP : MonoBehaviour
{
    public Transform Player;
    public int moveSpeed;
    public int dist;
    public int min;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(Player);

        if (Vector3.Distance(transform.position, Player.position) >= min)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;

            if (Vector3.Distance(transform.position, Player.position) <= dist)
            {
                //Here Call any function U want Like Shoot at here or something
            }
        }

        

    }
}

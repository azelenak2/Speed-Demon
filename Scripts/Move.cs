using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public float speedf = 1.5f;
    public Transform player;
    public KeyCode Forward;
    public KeyCode backwards;
    public KeyCode right;
    public KeyCode left;
    public GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame 
    void Update()
    {
        // Here we will store the position that this object will have at the end of the frame
        Vector3 frameDestination;
        // we set the varible to be the current position of the object for now
        frameDestination = transform.position;
        if (Input.GetKey(Forward))
        {
            frameDestination.y = frameDestination.y + speedf * Time.deltaTime;
        }



        if (Input.GetKey(backwards))
        {
            frameDestination.y = frameDestination.y - (speedf * Time.deltaTime);

        }

        if (Input.GetKey(right))
        {
            frameDestination.x = frameDestination.x + speedf * Time.deltaTime;
        }
        if (Input.GetKey(left))
        {
            frameDestination.x = frameDestination.x - speedf * Time.deltaTime;
        }
        this.transform.position = frameDestination;
       if (Input.GetKeyDown("space"))
        {
            shootBullet();
        }
    }

    public void shootBullet()
    {
        GameObject b = Instantiate(projectile) as GameObject;
        b.transform.position = player.transform.position;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    float move = 5f;

    Rigidbody rb;


 
    public GameObject target;
    Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindObjectOfType<GameObject>();
        moveDirection = (target.transform.position - transform.position).normalized * move;
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y);
        Destroy(gameObject, 3f);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

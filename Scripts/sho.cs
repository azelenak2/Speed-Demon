using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sho : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed = 50f;
    private Rigidbody rb;
    private Vector3 screenBounds;
    GameObject prefab;
    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, speed, 0);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter(Collider bp)
    {
        if (bp.tag == "Enemy")
        {
            Destroy(bp.gameObject);
        }
    }
}

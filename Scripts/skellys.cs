using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skellys : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerStay(Collider target)
    {
       if (target.tag == "Player")
        {
            Destroy(this.gameObject);
        }
    }

}

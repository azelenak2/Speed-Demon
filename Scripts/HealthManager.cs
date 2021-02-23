using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HealthManager : MonoBehaviour
{
    public HealthBar health;
    int maxhealth = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (maxhealth <= 0 )
        {
            SceneManager.LoadScene(2);
        }
    }


    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Bomb")
        {
            health.maxhealth -= 5;
        }

     

        
    }

   

}

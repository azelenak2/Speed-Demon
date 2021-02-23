using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Allkilledenemies : MonoBehaviour
{
    public GameObject[] enemieskilled;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemieskilled = GameObject.FindGameObjectsWithTag("Enemy"); 
        if(enemieskilled.Length == 0)
        {
            SceneManager.LoadScene("Victory");
        }
    }
}

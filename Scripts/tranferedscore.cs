using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class tranferedscore : MonoBehaviour
{
    public string sceneName;

   
    // Start is called before the first frame update
    void Start()
    {
        sceneName = SceneManager.GetActiveScene().name;
    }

       

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    private Vector3 screenborder;

    // Start is called before the first frame update
    void Start()
    {
        screenborder = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.x));   
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 viewPos = transform.position;
        viewPos.x = Mathf.Clamp(viewPos.x, screenborder.x, screenborder.x * -10);
        viewPos.x = Mathf.Clamp(viewPos.y, screenborder.y, screenborder.y * -10);
        viewPos.x = Mathf.Clamp(viewPos.z, screenborder.z, screenborder.z * -5);
        transform.position = viewPos;
    }
}

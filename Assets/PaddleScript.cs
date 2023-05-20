using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleScript : MonoBehaviour
{
    public GameObject anchor;
    public float velocity = 5;
    public static bool clockwise = true;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(clockwise)
            transform.RotateAround(anchor.transform.localPosition, Vector3.back, Time.deltaTime * velocity);
    }
}

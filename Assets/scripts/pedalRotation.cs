using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pedalRotation : MonoBehaviour
{

    private float rotSpeed = 300.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward * rotSpeed * Time.deltaTime);
    }
}

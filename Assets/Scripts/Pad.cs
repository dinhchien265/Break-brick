using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pad : MonoBehaviour
{
    public float speed = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 temp = transform.position;
        temp.x=Mathf.Clamp(temp.x + Input.GetAxis("Horizontal") * speed*Time.deltaTime,-4.5f,4.5f);
        transform.position = temp;
    }
}

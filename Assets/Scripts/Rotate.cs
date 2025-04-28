using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rotate : MonoBehaviour
{

    private float z;
    private float y;
    private float x;
    // Start is called before the first frame update
    void Start()
    {
        z = 0.2f;  //velocity
        y = 0.3f;
        x = 0.2f;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.Rotate(new Vector3(x,0,z)); //applying rotation
    }
}

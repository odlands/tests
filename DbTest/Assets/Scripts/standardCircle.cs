using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class standardCircle : MonoBehaviour
{
    public Rigidbody2D crc;
    public float force;
    public int scale;
    //private float maxRadius = 10;

    // Start is called before the first frame update
    void Start()
    {
        // maxRadius = GameObject.Find("HorizontalTop").transform.position.y - GameObject.Find("HorizontalBottom").transform.position.y;
        crc.AddForce(new Vector2(force, force));
        print("Scale variable uninitialized = " + scale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

}

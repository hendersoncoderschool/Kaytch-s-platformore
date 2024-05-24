using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovemnet : MonoBehaviour
{
    public float jumpforce;
    public float speed;
    private Rigidbody2D rb;// Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            print("d");
            rb.AddForce(transform.right * speed * Time.deltaTime);
        }
        if(Input.GetKey("a")){
            rb.AddForce(transform.right * -speed* Time.deltaTime);
        }
        if(Input.GetKeyDown("space")){
            rb.AddForce(transform.up*jumpforce,ForceMode2D.Impulse);
        }
        
    }
}

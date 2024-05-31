using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioMovemnet : MonoBehaviour
{
    public float jumpforce;
    public float speed;
    private Rigidbody2D rb;// Start is called before the first frame update
    public GameObject ded;
    public float maxspeed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey("d")){
            rb.AddForce(transform.right * speed * Time.deltaTime);
        }
        if(Input.GetKey("a")){
            rb.AddForce(transform.right * -speed* Time.deltaTime);
        }
        if(Input.GetKeyDown("space")){
            rb.AddForce(transform.up*jumpforce,ForceMode2D.Impulse);
        }
        if (rb.velocity.magnitude >= maxspeed){
            rb.velocity = rb.velocity.normalized * maxspeed;
        }
        print(rb.velocity.magnitude);
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.gameObject.CompareTag("goomba"))
        {
            if(transform.position.y > col.transform.position.y + 1.5f){
                rb.AddForce(transform.up*jumpforce,ForceMode2D.Impulse);
                Destroy(col.gameObject);
            }
            else
            {
                ded.SetActive(true);
                Destroy(gameObject);
            }

            

            
        }
        


    }
}

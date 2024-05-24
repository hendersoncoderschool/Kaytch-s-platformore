using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goombamovement : MonoBehaviour
{   public float leftbounds;
    public float rightbounds;
    private bool movingright = true;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(movingright){
            Vector2 newPos = transform.position;
            newPos.x += speed*Time.deltaTime;
            transform.position = newPos;
        }
        else{
            Vector2 newPos = transform.position;
            newPos.x += -speed*Time.deltaTime;
            transform.position = newPos;
        }
        if(transform.position.x >= 5){
            movingright = false;
        }
    }
}

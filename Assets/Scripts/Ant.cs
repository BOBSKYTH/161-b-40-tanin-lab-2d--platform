
using System;
using UnityEngine;

public class Ant : Enemy
{
    [SerializeField] Vector2 veloity;
    public Transform[] MovePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(30);
 
        DamagHit = 20;
        veloity = new Vector2(-1.0f, 0.0f);

    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + veloity * Time.fixedDeltaTime);
        //move left และเกินขอบซ้าย
        if (veloity.x < 0 && rb.position.x <= MovePoint[0].position.x)
        {
            Flip();
        }
        //move right และเกินขอบขวา
        if (veloity.x > 0 && rb.position.x >= MovePoint[1].position.x)
        {
            Flip();
        }

    }
    public void Flip()
    {
        veloity.x *= -1; //change direction of movement
                          //Flip the image
        Vector3 theScale = transform.localScale;
        theScale.x *= -1;
        transform.localScale = theScale;
    }
    private void FixedUpdate()
    {
        Behavior();
    }

   

    // Update is called once per frame
    void Update()
    {
        
    }
}

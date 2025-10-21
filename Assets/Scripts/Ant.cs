using UnityEngine;

public class Ant : Enemy
{
    [SeriaLizeFiald] Vector2 veloity;
    public Transform[] MovePoint;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(30);
 
        DamageHit = 20;
        veloity = new Vector2(-1.0f, 0.0f);

    }


    public override void Bahvior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);
        
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

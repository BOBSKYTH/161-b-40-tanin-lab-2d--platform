using UnityEngine;

public class Ant : Enemy
{
    [SeriaLizeFiald] Vector2 veloity;
    public Transform[] MovePoint;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        base.Intialize(30);
    }

    

    public override void Bahvior()
    {
        throw new System.NotImplementedException();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

using UnityEngine;

public abstract class Enemy : Character
{
    public int DamagHit { get; protected set; }
    public void takeDamage(int damage)
    {
        damage -= Health;
    }


    public abstract void Behavior();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

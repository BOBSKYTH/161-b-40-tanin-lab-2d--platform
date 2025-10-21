using UnityEngine;

public abstract class Enemy : Character
{
    public int DamagHit { get; protected set; }


    
    public abstract void Bahvior();


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

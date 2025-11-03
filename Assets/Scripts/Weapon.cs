using UnityEngine;

public abstract class Weapon : MonoBehaviour
{
    public int damge;
    public IShootable Shootable;
    public abstract void Move();

    public abstract void OnHitwith(Character character);

    public int GetShootDirection()
    {
        float value = Shootable.ShootPoint.position.x - Shootable.ShootPoint.parent.position.x;

        if (value > 0) 
            return 1;
        else return -1;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Character character = other.GetComponent<Character>();
        if (character != null)
        {
            OnHitwith(character);
            Destroy(this.gameObject, 5f);
        }
    }
    public void InitWeapon(int newDamage, IShootable newShooter)
    {
        damge = newDamage;
        Shootable = newShooter;
    }


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

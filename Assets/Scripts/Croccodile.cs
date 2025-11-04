using UnityEngine;

public class Croccodile : Enemy, IShootable
{
    [SerializeField] private float atkRange;
    public Player player; //target to atk

    [field: SerializeField] public GameObject Bullet { get; set; }
    [field: SerializeField] public Transform ShootPoint { get; set; }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }

    void Start()
    {
        Hp.maxValue = 50;
        base.Initialize(50);
        DamagHit = 30;
        atkRange = 6.0f;
        ReloadTime = 1f;
        player = GameObject.FindFirstObjectByType<Player>();

    }

    private void FixedUpdate()
    {
        
        WaitTime += Time.fixedDeltaTime;
        Behavior();
        Hp.value = Health;
    }
    public override void Behavior()
    {
        //find distance between Croccodile and Player
        Vector2 distance = transform.position - player.transform.position;
        if (distance.magnitude <= atkRange)
        {
            Debug.Log($"{player.name} is in the {this.name}'s atk range!");
            Shoot();
        }
    }
    public void Shoot()
    {
        if (WaitTime >= ReloadTime)
        {
            anim.SetTrigger("Shoot");
            var bullet = Instantiate(Bullet, ShootPoint.position, Quaternion.identity);
            Rock rock = bullet.GetComponent<Rock>();
            rock.InitWeapon(30, this);
            WaitTime = 0 ;

        }
    }
}

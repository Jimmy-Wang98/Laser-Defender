using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public float health = 150f;

    public GameObject Laser;
    public float lasersnelheid;
    public float shotsPerSeconds = 2f;


    void Fire()
    {
        Vector3 startPositie = transform.position + new Vector3(0, -1f, 0);
        GameObject beam = Instantiate(Laser, startPositie, Quaternion.identity) as GameObject;
        beam.GetComponent<Rigidbody2D>().velocity = new Vector2(0, -lasersnelheid);
    }


    void Die()
    {
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        Projectile missile = col.GetComponent<Projectile>();
        if (missile)
        {
            health -= missile.GetDamage();
            if (health <= 0)
            {
                Die();
            }
            missile.Hit();
        }
    }



    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mogelijkheid = Time.deltaTime * shotsPerSeconds;
        if (Random.value < mogelijkheid)
        {
            Fire();
        }
	}
}

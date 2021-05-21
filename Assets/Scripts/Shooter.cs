using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] GameObject projectilePrefab;
    [SerializeField] GameObject gun;
    [SerializeField] Animator animator;
    [SerializeField] int damage;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //fire();
    }

    private void OnTriggerEnter2D(Collider2D otherCollider)
    {
        Health enemyHealth = otherCollider.GetComponent<Health>();
        Enemy enemy = otherCollider.GetComponent<Enemy>();
        if (enemyHealth && enemy)
        {
            enemyHealth.DealDamage(damage);
            Destroy(gameObject);
        }
    }

    public void Fire()
    {
        var projectile = Instantiate(projectilePrefab, gun.transform.position, Quaternion.identity);
    }
}

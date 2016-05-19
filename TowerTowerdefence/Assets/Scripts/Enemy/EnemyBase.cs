using UnityEngine;
using System.Collections;

public class EnemyBase : EnemyMovement {

    public float maxHealth;
    public float health;

    public float slowedTime;

    public int goldReward;

    public bool isSlowed;
    public bool isDead;
    public SpawnManager sManager;

    public Animator anim;

    public override void Start() {
        base.Start();
        maxHealth = health;
    }

    public void DamageEnemy(float dmg) {
        //Inflict damage on the enemy
        health -= dmg;
        if (health <= 0) {
            DestroyEnemy();
        }
    }

    public void DestroyEnemy() {
        // Destroys the enemy

        
        Destroy(gameObject);
    }

    public void Slowed() {
        isSlowed = true;
        StartCoroutine("SlowedDelay");
    }

    IEnumerator SlowedDelay() {
        speed /= 2;
        yield return new WaitForSeconds(slowedTime);
        speed *= 2;
    } 
}

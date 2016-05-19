﻿using UnityEngine;
using System.Collections;

public class EnemyBase : EnemyMovement {

    public float maxHealth;                 //Maximum health the enemy can have
    public float health;                    //Health the enemy has

    public float slowedTime;    

    public int goldReward;                  //Resource reward for player

    private Renderer childRenderer;         //Renderer of child gameobject

    private Color colorStart;               //Fade color start
    private Color colorEnd;                 //Fade color end

    public Shader alphaShader;              //Shader for fading

    public bool isSlowed;                   //bool to check if the enemy is slowed
    public bool isDead = false;             //bool to check if the enemy is dead
    public SpawnManager sManager;           

    private Animator anim;          

    public override void Start() {
        base.Start();
        maxHealth = health;
    }

    void LateUpdate() {
        if (isDead) {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Death")) {
               FadeOut();
            }
        }
    }

    public void FadeOut() {
        //TO DO: werk nog niet goed met shroom 1.2, color doet raar

        colorStart = GetComponentInChildren<Renderer>().material.color;
        colorEnd = new Color(colorStart.r, colorStart.g, colorStart.b, 0.0f);

        childRenderer = GetComponentInChildren<Renderer>();
        childRenderer.material.shader = alphaShader;
        childRenderer.material.color = Color.Lerp(colorStart, colorEnd, Time.deltaTime);

        if (childRenderer.material.color.a <= 0.05f) {
            DestroyEnemy();
        }
    }

    public void DamageEnemy(float dmg) {
        //Inflict damage on enemy
        health -= dmg;
        if (health <= 0) {
            KillEnemy();
        }
    }

    public void KillEnemy() {
        //Kills the enemy
        if (!isDead) {
            anim = GetComponentInChildren<Animator>();
            anim.SetBool("Dead", true);
            isDead = true;
            ableToMove = false;
        }
    }

    public void DestroyEnemy() {
        //Destroy the enemy 
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

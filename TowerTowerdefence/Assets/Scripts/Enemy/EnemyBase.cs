using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyBase : EnemyMovement {

    [Header("Health Stats")]
    public float maxHealth;                 //Enemy maximum health
    public float health;                    //Health the enemy has   

    [Header("Rewards")]
    [SerializeField]
    protected int goldReward;                  //Resource reward for killing the enemy

    [HideInInspector]
    public bool isDead = false;             //bool to check if the enemy is dead

    [Space(20)]
    [SerializeField]
    private Shader alphaShader;              //Shader for fading

    private Renderer childRenderer;         //Renderer of child gameobject
    private Color colorStart;               //Fade color start
    private Color colorEnd;                 //Fade color end

    [SerializeField]
    protected Image healthBar;              //Enemy health point graphic

    protected Animator anim;                //Enemy animator controller
    protected AudioSource audioSource;      //Audiosource on enemy
    protected AudioClip deathAudio;         //Audioclip played on death   

    public override void Start()
    {
        base.Start();
    }

    public void FadeOut()
    {
        //Get the start and end colors for the fade
        colorStart = GetComponentInChildren<Renderer>().material.color;
        colorEnd = new Color(colorStart.r, colorStart.g, colorStart.b, 0.0f);

        //Get renderer component, set shader and lerp color
        childRenderer = GetComponentInChildren<Renderer>();
        childRenderer.material.shader = alphaShader;
        childRenderer.material.color = Color.Lerp(colorStart, colorEnd, Time.deltaTime);

        //If the enemy is faded beyond visability, destroy it.
        if (childRenderer.material.color.a <= 0.05f)
        {
            DestroyEnemy();
        }
    }

    public void DamageEnemy(float dmg)
    {
        //Inflict damage on enemy
        health -= dmg;

        //Set HP bar to correct fill amount
        healthBar.fillAmount = health / maxHealth;
        if (health <= 0)
        {
            KillEnemy();
        }
    }

    private void KillEnemy()
    {
        //Kills the enemy
        if (!isDead)
        {
            //Disables movement
            ableToMove = false;

            //Play death animation
            anim = GetComponentInChildren<Animator>();
            anim.SetBool("Dead", true);

            //Play death sound
            audioSource.PlayOneShot(deathAudio);

            //Reward gold to player
            rManager.AddGold(goldReward);
            isDead = true;
        }
    }
  
    private void DestroyEnemy()
    {
        //Destroy the enemy 
        Destroy(gameObject);
    }
}

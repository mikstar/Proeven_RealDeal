using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class BossScript : EnemyBase{

    public AudioClip deathsound;        //Sound this enemy makes when dying

    public int baseDMG;                 //Damage this enemy does to player base

    public override void Start()
    {
        //Getting audiosource
        audioSource = GetComponent<AudioSource>();

        deathAudio = deathsound;

        healthBar = transform.FindChild("EnemyCanvas").FindChild("Fill").GetComponent<Image>();
    }

    void FixedUpdate()
    {
        Move(baseDMG);

        if (isDead)
        {
            if (anim.GetCurrentAnimatorStateInfo(0).IsName("Death"))
            {
                FadeOut();
            }
        }
    }
}

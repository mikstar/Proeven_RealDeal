using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class EnemyMushroom : EnemyBase {

    public AudioClip deathsound;
    public int baseDMG;
  

	public override void Start () {
        audioSource = GetComponent<AudioSource>();
        deathAudio = deathsound;

        healthBar = transform.FindChild("EnemyCanvas").FindChild("Fill").GetComponent<Image>();
    }

    void FixedUpdate(){
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

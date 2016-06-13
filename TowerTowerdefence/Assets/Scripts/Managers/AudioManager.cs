using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioClip newWaveSound;                  //Audio played when a new wave starts
    public AudioClip waveClearedSound;              //Audio played when a wave is cleared
    public AudioClip gameWonSound;                  //Audio played when the game is won
    public AudioClip gameLostSound;                 //Audio played when the game is lost.
            
    public AudioClip towerConstructingSound;        //Audio played when a tower is under contruction
    public AudioClip towerConstructedSound;         //Audio played when a tower is constructed
    public AudioClip towerUpgradedSound;            //Audio played when a tower is upgraded
    public AudioClip towerSoldSound;                //Audio played when a tower is sold


    public AudioClip baseDMG;

    private AudioSource aSource;

    void Start()
    {
        aSource = GetComponent<AudioSource>();
    }
    
    /// <summary>
    /// Play audioclip for a new wave, once.
    /// </summary>
    public void PlayNewWave() {
        aSource.PlayOneShot(newWaveSound);
    }

    /// <summary>
    /// Play audioclip for when a wave is cleared, once.
    /// </summary>
    public void PlayWaveCleared() {
        aSource.PlayOneShot(waveClearedSound);
    }

    /// <summary>
    /// Play audioclip for the contruction of a tower, once.
    /// </summary>
    public void PlayTowerConstructed() {
        aSource.PlayOneShot(towerConstructingSound);
    }

    /// <summary>
    /// Play audioclip for selling a tower, once.
    /// </summary>
    public void PlayTowerSold() {
        aSource.PlayOneShot(towerSoldSound);
    }

    /// <summary>
    /// Play audioclip for upgrading a tower, once.
    /// </summary>
    public void PlayTowerUpgrade() {
        aSource.PlayOneShot(towerConstructedSound);
    }

    /// <summary>
    /// Play audioclip for taking damage as player, once.
    /// </summary>
    public void PlayBaseDMG() {
        aSource.PlayOneShot(baseDMG);
    }

    /// <summary>
    /// Play audioclip for losing the game.
    /// </summary>
    public void PlayGameOver() {
        aSource.PlayOneShot(gameLostSound);

        AudioSource aS = transform.GetChild(0).GetComponent<AudioSource>();
        aS.volume = 0.2f;
    }

}

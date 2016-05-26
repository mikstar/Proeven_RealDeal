using UnityEngine;
using System.Collections;

public class AudioManager : MonoBehaviour {

    public AudioClip newWaveSound;
    public AudioClip waveClearedSound;
    public AudioClip gameWonSound;
    public AudioClip gameLostSound;

    public AudioClip towerConstructingSound;
    public AudioClip towerConstructedSound;
    public AudioClip towerUpgradedSound;
    public AudioClip towerSoldSound;

    private AudioSource aSource;

    void Start() {
        aSource = GetComponent<AudioSource>();
    }

    public void PlayNewWave() {
        aSource.PlayOneShot(newWaveSound);
    }

    public void PlayWaveCleared() {
        aSource.PlayOneShot(waveClearedSound);
    }

    public void PlayTowerConstructed() {
        aSource.PlayOneShot(towerConstructingSound);
    }

    public void PlayTowerSold() {
        aSource.PlayOneShot(towerSoldSound);
    }

    public void PlayTowerUpgrade() {
        aSource.PlayOneShot(towerConstructedSound);
    }
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Camfade : MonoBehaviour
{
    public bool fadeInAtStart = true;
    public GameObject fadeObj;
    private int lvlNum = 0;

    // Use this for initialization
    void Start()
    {
        fadeObj.GetComponent<RectTransform>().sizeDelta = new Vector2(Screen.width, Screen.height);
        if (fadeInAtStart)
        {
            fadeObj.GetComponent<Image>().DOFade(0, 1.5f).OnComplete(disableFade);
        }
    }
    /// <summary>
    /// Fade screen to black
    /// </summary>
    public void fadeOut()
    {
        fadeObj.SetActive(true);
        fadeObj.GetComponent<Image>().DOFade(1, 1.5f).OnComplete(disableFade);
    }
    /// <summary>
    /// Fade screen to black, then change to given scene when fade is done
    /// </summary>
    public void fadeOutNewScene(int sceneNum)
    {
        lvlNum = sceneNum;
        fadeObj.SetActive(true);
        fadeObj.GetComponent<Image>().DOFade(1, 1.5f).OnComplete(nextScene);
    }
    private void nextScene()
    {
        SceneManager.LoadScene(lvlNum);
    }

    //disable grafic used for fading, so there'a no idle, active obj's
    private void disableFade()
    {
        fadeObj.SetActive(false);
    }

}
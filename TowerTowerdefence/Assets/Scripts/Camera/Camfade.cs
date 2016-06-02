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
    public void fadeOut()
    {
        fadeObj.SetActive(true);
        fadeObj.GetComponent<Image>().DOFade(1, 1.5f).OnComplete(disableFade);
    }
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

    private void disableFade()
    {
        fadeObj.SetActive(false);
    }

}
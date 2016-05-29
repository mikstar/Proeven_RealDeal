using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TempTutScript : MonoBehaviour
{

    public GameObject[] tuts;
    public Transform[] nextPos;

    public Button next;
    public Button skip;
    public Button startgame;

    public Image fadeBack;

    public int currentFrame;

    void Start() {
        
        startgame.gameObject.SetActive(false);
    }

    public void Next()
    {
        currentFrame++;

        switch (currentFrame)
        {
            case 1:
                SetFrame();
                skip.gameObject.SetActive(false);
                
                break;
            case 2:
                SetFrame();
                break;
            case 3:
                SetFrame();
                break;
            case 4:
                SetFrame();
                
                break;
            case 5:
                SetFrame();
                fadeBack.gameObject.SetActive(false);     
                break;
            case 6:
                SetFrame();
                next.gameObject.SetActive(false);
                startgame.gameObject.SetActive(true);
                startgame.gameObject.transform.position = nextPos[currentFrame].position;
                break;
        }
    }

    public void Skip() {
        this.gameObject.SetActive(false);
        tuts[currentFrame].SetActive(false);
        fadeBack.gameObject.SetActive(false);
    }

    public void SetFrame() {
        for (int i = 0; i < tuts.Length; i++)
        {
            tuts[i].SetActive(false);
        }
        tuts[currentFrame].SetActive(true);
        next.gameObject.transform.position = nextPos[currentFrame].position;
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Tutorial : MonoBehaviour
{
    public GameObject[] tuts;       // Array of tutorial frames
    public Transform[] nextPos;     // Array of transforms for Next Button

    public Button next;             // Next tutorial frame button
    public Button skip;             // Skip tutorial btton
    public Button startgame;        // Start game button

    public GameObject resource;     // Resource UI object
    public GameObject waveInfo;     // Wave information UI object
    public GameObject waveButt;     // Next wave button
    public GameObject buttons;      // Tower placement UI object

    public Image fadeBack;          // Fade image

    public HUD hud;                 // HUD script
   
    public int currentFrame;  
    

    void Start() {
        
        startgame.gameObject.SetActive(false);
    }

    /// <summary>
    /// Set tutorial UI to next frame
    /// </summary>
    public void Next()
    {
        currentFrame++;

        switch (currentFrame)
        {
            case 1:
                SetFrame();
                skip.gameObject.SetActive(false);
                resource.gameObject.SetActive(true);
                break;
            case 2:
                SetFrame();
                buttons.gameObject.SetActive(true);
                break;
            case 3:
                SetFrame();
                hud.HUDactive = true;
                waveInfo.gameObject.SetActive(true);
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

    /// <summary>
    /// Skip entire tutorial - Deactivate all tutorial UI and Activate all game UI
    /// </summary>
    public void Skip()
    {
        this.gameObject.SetActive(false);
        tuts[currentFrame].SetActive(false);
        fadeBack.gameObject.SetActive(false);

        resource.gameObject.SetActive(true);
        buttons.gameObject.SetActive(true);
        hud.HUDactive = true;
        waveInfo.gameObject.SetActive(true);
    }

    /// <summary>
    /// Set UI for current tutorial frame
    /// </summary>
    public void SetFrame()
    {
        for (int i = 0; i < tuts.Length; i++)
        {
            tuts[i].SetActive(false);
        }
        tuts[currentFrame].SetActive(true);
        next.gameObject.transform.position = nextPos[currentFrame].position;
    }
}

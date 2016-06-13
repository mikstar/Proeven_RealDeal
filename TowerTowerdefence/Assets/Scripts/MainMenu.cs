using UnityEngine;
using System.Collections;
using DG.Tweening;

public class MainMenu : MonoBehaviour {

    //saves UI objects that this scrips cycles between
    public Transform firstScreen;
    public Transform lvlScreen;
    public Transform creditsScreen;

    private Transform cam;
    
    void Start()
    {
        //save camera transform for later use
        cam = Camera.main.transform;
    }

    /// <summary>
    /// move level-select on screen, removing first-screen
    /// </summary>
    public void ToLvlSelect()
    {
        firstScreen.DOMoveX(firstScreen.position.x-(lvlScreen.position.x - firstScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        lvlScreen.DOMoveX(firstScreen.position.x, 0.8f).SetEase(Ease.OutQuart);
        //move camera, causing a shift in the background
        cam.DOMove(new Vector3(13, 14, -31),0.8f).SetEase(Ease.OutQuart);
    }
    /// <summary>
    /// move credits on screen, removing first-screen
    /// </summary>
    public void ToCredits()
    {
        firstScreen.DOMoveX(firstScreen.position.x - (creditsScreen.position.x - firstScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        creditsScreen.DOMoveX(firstScreen.position.x, 0.8f).SetEase(Ease.OutQuart);
        //move camera, causing a shift in the background
        cam.DOMove(new Vector3(3, 14, -31), 0.8f).SetEase(Ease.OutQuart);

    }
    /// <summary>
    /// move first-screen on screen, removing credits
    /// </summary>
    public void ToFirstScreen()
    {
        creditsScreen.DOMoveX(creditsScreen.position.x - (firstScreen.position.x - creditsScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        firstScreen.DOMoveX(creditsScreen.position.x, 0.8f).SetEase(Ease.OutQuart);        
        //move camera, causing a shift in the background
        cam.DOMove(new Vector3(8, 14, -31), 0.8f).SetEase(Ease.OutQuart);
    }
}

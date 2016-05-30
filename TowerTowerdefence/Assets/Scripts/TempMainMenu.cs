using UnityEngine;
using System.Collections;
using DG.Tweening;

public class TempMainMenu : MonoBehaviour {

    public Transform firstScreen;
    public Transform lvlScreen;
    public Transform creditsScreen;

    private Transform cam;
    
    void Start()
    {
        cam = Camera.main.transform;
    }

    public void ToLvlSelect()
    {
        firstScreen.DOMoveX(firstScreen.position.x-(lvlScreen.position.x - firstScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        lvlScreen.DOMoveX(firstScreen.position.x, 0.8f).SetEase(Ease.OutQuart);

        cam.DOMove(new Vector3(13, 14, -31),0.8f).SetEase(Ease.OutQuart);
    }
    public void ToCredits()
    {
        firstScreen.DOMoveX(firstScreen.position.x - (creditsScreen.position.x - firstScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        creditsScreen.DOMoveX(firstScreen.position.x, 0.8f).SetEase(Ease.OutQuart);

        cam.DOMove(new Vector3(3, 14, -31), 0.8f).SetEase(Ease.OutQuart);

    }
    public void ToFirstScreen()
    {
        creditsScreen.DOMoveX(creditsScreen.position.x - (firstScreen.position.x - creditsScreen.position.x), 0.8f).SetEase(Ease.OutQuart);
        firstScreen.DOMoveX(creditsScreen.position.x, 0.8f).SetEase(Ease.OutQuart);

        cam.DOMove(new Vector3(8, 14, -31), 0.8f).SetEase(Ease.OutQuart);

    }



}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TooltipControl : MonoBehaviour
{
    private bool isActive;
    public RectTransform tooltipFrame;
    public Text tooltipText;

    // Update is called once per frame
    void FixedUpdate()
    {
        //make tooltipwindow follow mouse
        tooltipFrame.position = Input.mousePosition;
    }
    //turn tooltipwindow on and set its text
    public void addNewText(string txt)
    {
        tooltipFrame.gameObject.SetActive(true);
        this.enabled = true;
        tooltipText.text = txt;
    }
    //turn off tooltip window and update loop
    public void turnOff()
    {
        this.enabled = false;
        tooltipFrame.gameObject.SetActive(false);
    }
}

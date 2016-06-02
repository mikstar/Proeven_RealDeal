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
        tooltipFrame.position = Input.mousePosition;
    }

    public void addNewText(string txt)
    {
        tooltipFrame.gameObject.SetActive(true);
        this.enabled = true;
        tooltipText.text = txt;
    }
    public void turnOff()
    {
        this.enabled = false;
        tooltipFrame.gameObject.SetActive(false);
    }
}

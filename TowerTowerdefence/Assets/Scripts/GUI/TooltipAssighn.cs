using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TooltipAssighn : MonoBehaviour {

    public string tooltipText;
    //saved tooltip control to call when moused over
    private TooltipControl contrlObj;

	// Use this for initialization
	void Start () {
        contrlObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<TooltipControl>();

        gameObject.AddComponent<EventTrigger>();

        EventTrigger trigger = GetComponentInParent<EventTrigger>();
        EventTrigger.Entry entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerEnter;
        entry.callback.AddListener((eventData) => { mouseEnter(); });
        trigger.triggers.Add(entry);
        entry = new EventTrigger.Entry();
        entry.eventID = EventTriggerType.PointerExit;
        entry.callback.AddListener((eventData) => { mouseExit(); });
        trigger.triggers.Add(entry);
        
    }

    void mouseEnter()
    {
        contrlObj.addNewText(tooltipText);
    }

    void mouseExit()
    {
        contrlObj.turnOff();
    }
}

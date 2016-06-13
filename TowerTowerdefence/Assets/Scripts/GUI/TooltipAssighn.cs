using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class TooltipAssighn : MonoBehaviour {
    //...
    // This script is to be set on all UI objects with a tooltip
    //...

    public string tooltipText;
    //saved tooltip control to call when moused over
    private TooltipControl contrlObj;

	// Use this for initialization
	void Start () {
        //Find the main tooltip controll script
        contrlObj = GameObject.FindGameObjectWithTag("GameController").GetComponent<TooltipControl>();

        //add event triggers to the UI obj so it calls mouseEnter and mouseExit
        //(this stops the need to add these maualy in the editer )
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
    //sent new text to tooltipControll
    void mouseEnter()
    {
        contrlObj.addNewText(tooltipText);
    }
    
    void mouseExit()
    {
        contrlObj.turnOff();
    }
}

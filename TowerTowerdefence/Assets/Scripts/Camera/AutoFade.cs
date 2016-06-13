using UnityEngine;
using System.Collections;

public class AutoFade : MonoBehaviour {

    private Material mat;
    public float fadeAmmount;//public to controll how fast obj fades
    
	void Start()
    {
        //save material for easy acces in update loop
        mat = GetComponent<Renderer>().material;
    }

	// Update is called once per frame
	void Update () {
        //cheack if obj is completely faded out, turn obj off if so
        if (mat.color.a <= fadeAmmount)
        {
            gameObject.SetActive(false);
        }
        else
        {
            //fade object, and move offset to make the effect feel more active
            mat.color = new Color(1, 1, 1, mat.color.a - fadeAmmount);
            mat.SetTextureOffset("_MainTex", new Vector2(mat.GetTextureOffset("_MainTex").x-0.1f, 0));
        }
	}

    //reset and restore alpha so fading can resume
    public void reset()
    {
        gameObject.SetActive(true);
        GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}

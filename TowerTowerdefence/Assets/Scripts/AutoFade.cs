using UnityEngine;
using System.Collections;

public class AutoFade : MonoBehaviour {

    private Material mat;
    public float fadeAmmount;

	void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

	// Update is called once per frame
	void Update () {
        if (mat.color.a <= fadeAmmount)
        {
            gameObject.SetActive(false);
        }
        else
        {
            mat.color = new Color(1, 1, 1, mat.color.a - fadeAmmount);
            mat.SetTextureOffset("_MainTex", new Vector2(mat.GetTextureOffset("_MainTex").x-0.1f, 0));
        }
	}

    public void reset()
    {
        gameObject.SetActive(true);
        GetComponent<Renderer>().material.color = new Color(1, 1, 1, 1);
    }
}

using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GUIUpdateText : MonoBehaviour
{
    public Text TextObject = null;

	// Use this for initialization
	void Start()
    {
	    if(TextObject == null)
        {
            TextObject = gameObject.GetComponent<Text>();
        }
	}
	
	// Update is called once per frame
	void Update()
    {
	
	}

    public void TextUpdate(string data)
    {
        if(TextObject != null)
        {
            TextObject.text = data;
        }
    }

    public void TextUpdate(int data)
    {
        if (TextObject != null)
        {
            TextObject.text = data.ToString();
        }
    }

    public void TextUpdate(float data)
    {
        if (TextObject != null)
        {
            TextObject.text = data.ToString("0.00");
        }
    }
}

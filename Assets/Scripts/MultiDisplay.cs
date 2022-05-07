using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiDisplay : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        createMultiDisplay();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void createMultiDisplay()
    {
        Debug.Log(Display.displays.Length);
        for (int i = 1; i < Display.displays.Length; i++)
            Display.displays[i].Activate();
    }
}

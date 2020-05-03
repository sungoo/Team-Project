using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UpButton : MonoBehaviour
{
    bool buttonDown = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData ped)
    {
        buttonDown = true;
    }

    public void OnPointerUp(PointerEventData ped)
    {
        buttonDown = false;
    }
}

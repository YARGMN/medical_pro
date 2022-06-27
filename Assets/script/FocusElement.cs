using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FocusElement : MonoBehaviour
{

    private GameObject objectToShow;
    public GameObject[] objectToHide;

    private bool isPressed;
    // Start is called before the first frame update
    
    void Start()
    {
        objectToShow = transform.gameObject;
        isPressed = false;
    }
    
    public void handlePress()
    {
        Debug.Log("pressed");
        if(isPressed)
        {
            foreach (var hide in objectToHide)
            {
                hide.SetActive(true);
                isPressed = false;
            }
        } else
        {
            objectToShow.SetActive(true);
            foreach (var hide in objectToHide)
            {
                hide.SetActive(false);
            }
            isPressed = true;
        }
    }
}

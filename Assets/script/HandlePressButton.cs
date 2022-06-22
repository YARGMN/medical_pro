using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePressButton : MonoBehaviour
{

    public GameObject toShow;
    public GameObject[] toHide;
    
    public void OnClick()
    {
        toShow.SetActive(true);
        foreach(var hide in toHide) {
            hide.SetActive(false);
        }
    }
}

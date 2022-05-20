using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandlePress : MonoBehaviour
{

    public GameObject organe;

    string organe_title;

    string organe_content;

    public void OnClick()
    {
        organe_title = organe.name;
        Debug.Log(organe_title);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class panel : MonoBehaviour
{
    public GameObject panelObject;
    // Start is called before the first frame update
    void Start()
    {
        panelObject.SetActive(false);
    }

    // Update is called once per frame
    public void TogglePanel()
    {
        panelObject.SetActive(!panelObject.activeSelf);
    }
}

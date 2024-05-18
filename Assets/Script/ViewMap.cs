using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMap : MonoBehaviour
{
    public GameObject mapObject;
    public void ToggleMap()
    {
        mapObject.SetActive(!mapObject.activeSelf);
    }
}

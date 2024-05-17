using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public GameObject textObject;

    public void OnButtonClick()
    {
        StartCoroutine(ShowAndHide(textObject, 2.0f));
    }

    IEnumerator ShowAndHide(GameObject obj, float delay)
    {
        obj.SetActive(true);
        yield return new WaitForSeconds(delay);
        obj.SetActive(false);
    }
}

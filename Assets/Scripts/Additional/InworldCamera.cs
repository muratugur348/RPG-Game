using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InworldCamera : MonoBehaviour
{
    public GameObject connectionCanvas;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        yield return new WaitForSeconds(0.5f);
        StartCoroutine(WaitConnectionToDeactivate());
    }

    private IEnumerator WaitConnectionToDeactivate()
    {
        yield return new WaitForEndOfFrame();
        if (!connectionCanvas.activeInHierarchy)
        {
            gameObject.SetActive(false);
        }
        else
        StartCoroutine(WaitConnectionToDeactivate());

    }
}

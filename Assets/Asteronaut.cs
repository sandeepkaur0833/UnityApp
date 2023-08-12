using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Asteronaut : MonoBehaviour
{
    public GameObject controlsObject;

    public void Start()
    {
        controlsObject.SetActive(false);
    }

    public void modalHide()
    {
        controlsObject.SetActive(!controlsObject.activeSelf);
    }

    public void Hide()
    {
        controlsObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToggleDirectReference : MonoBehaviour
{
    [SerializeField] GameObject mainCamera;
    [SerializeField] GameObject skyboxCamera;
    public void Toggle()
    {
        skyboxCamera.SetActive(!skyboxCamera.activeSelf);
        mainCamera.SetActive(!mainCamera.activeSelf);
    }
}

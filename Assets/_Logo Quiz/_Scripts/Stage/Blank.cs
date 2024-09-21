using System;
using UnityEngine;
using UnityEngine.UI;

public class Blank : MonoBehaviour
{
    public RectTransform rectTransform;

    private void OnEnable()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}

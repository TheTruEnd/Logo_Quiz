using System;
using UnityEngine;
using UnityEngine.UI;

public class Blank : MonoBehaviour
{
    public RectTransform rectTransform;
    public bool isFilled;
    public int alphabetIndex;
    

    private void OnEnable()
    {
        alphabetIndex = -1;
        rectTransform = GetComponent<RectTransform>();
    }
}

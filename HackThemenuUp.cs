using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HackThemenuUp : MonoBehaviour
{
    public void ScrollTop() {
        GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
    }
}

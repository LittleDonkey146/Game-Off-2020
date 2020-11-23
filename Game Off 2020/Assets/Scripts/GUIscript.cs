using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUIscript : MonoBehaviour
{
    public Texture2D texture;

    GUIStyle style =  new GUIStyle();

    private void Start()
    {

        style.alignment = TextAnchor.MiddleCenter;
    }

    private void OnGUI()
    {
        GUI.Box(new Rect(0, 0, 200, 50), "Hello", style);
    }
}

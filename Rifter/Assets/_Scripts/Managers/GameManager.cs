using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Texture2D cursorTexture = null;

    private void Start()
    {
        SetCourserIcon();
    }

    private void SetCourserIcon()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(cursorTexture.width/2f*2, cursorTexture.height/2f*2),
            CursorMode.Auto);
    }
}

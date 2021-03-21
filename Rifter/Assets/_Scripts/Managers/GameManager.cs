using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    [SerializeField] private Texture2D cursorTexture = null;

    private void Start()
    {
        SetCourserIcon();
    }

    private void SetCourserIcon()
    {
        Cursor.SetCursor(cursorTexture, new Vector2(cursorTexture.width, cursorTexture.height),
            CursorMode.Auto);
    }

    public void RestartLevel()
    {
        DOTween.KillAll();
        Debug.Log("I'm pressed");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}

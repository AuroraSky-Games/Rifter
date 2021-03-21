using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;
using Image = UnityEngine.UI.Image;

public class UIHealth : MonoBehaviour
{
    [SerializeField] private GameObject hearthPrefab = null, healthPanel;
    [SerializeField] private Sprite heartFull = null, heartEmpty = null;

    private int heartCount = 0;
    
    private readonly List<Image> _hearts = new List<Image>();

    public void Initialize(int liveCount)
    {
        heartCount = liveCount;
        
        foreach (Transform child in healthPanel.transform)
        {
            Destroy(child.gameObject);
        }

        for (int i = 0; i < heartCount; i++)
        {
            _hearts.Add(Instantiate(hearthPrefab, healthPanel.transform).GetComponent<Image>());
        }
    }

    public void UpdateUI(int health)
    {
        int currendtIndex = 0;

        for (int i = 0; i < heartCount; i++)
        {
            if (currendtIndex >= health)
            {
                _hearts[i].sprite = heartEmpty;
            }
            else
            {
                _hearts[i].sprite = heartFull;
            }

            currendtIndex++;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayableCard : MonoBehaviour
{
    public Card card;

    public bool invert = false;

    public TextMeshPro text;
    public Material image;
    Material cardColor;
    public Renderer cardImageRenderer;

    // Start is called before the first frame update
    void Start()
    {
        GetCardInformation();
    }

    private void Update()
    {
        if (invert)
        {
            Invert();
            invert = false;
        }
    }

    void Invert()
    {
        card.Invert();
        GetCardInformation();
    }

    void GetCardInformation()
    {
        text.text = card.GetText();
        cardColor = GetComponent<Renderer>().materials[1];
        cardColor.color = card.GetColor();
        cardImageRenderer.material = card.GetImage();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class PlayableCard : MonoBehaviour
{
    public Card card;

    public bool inverted = false;

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
        if (inverted)
        {
            Invert();
            inverted = false;
        }
    }

    void Invert()
    {
        inverted = !inverted;
        GetCardInformation();
    }

    void GetCardInformation()
    {
        text.text = card.GetText(inverted);
        cardColor = GetComponent<Renderer>().materials[1];
        cardColor.color = card.GetColor(inverted);
        cardImageRenderer.material = card.GetImage(inverted);
    }
}

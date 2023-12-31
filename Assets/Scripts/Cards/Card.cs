using UnityEngine;
using UnityEngine.UI;

[CreateAssetMenu(fileName = "New Card", menuName = "Card")]
public class Card : ScriptableObject
{
    [SerializeField]
    int value;
    [SerializeField]
    string text;
    [SerializeField]
    string invertedText;
    [SerializeField]
    string effect;
    [SerializeField]
    string invertedEffect;
    [SerializeField]
    Material image, invertedImage;
    [SerializeField]
    Sprite sprite, invertedSprite;
    [SerializeField]
    Color color, invertedColor;
    

    public string GetText(bool inverted)
    {
        string[] aux;
        if (inverted) 
        {
            aux = invertedText.Split('$');
        }else
        {
            aux = text.Split('$');
        }

        
        string newText = "";

        for (int i = 0; i < aux.Length; i++)
        {
            if (aux[i] == "v")
            {
                aux[i] = value.ToString();
            }

            newText += aux[i];
        }

        return newText;
    }

    public Color GetColor(bool inverted)
    {
        if (inverted)
        {
            return invertedColor;
        }
        else
        {
            return color;
        }
    }

    public Material GetImage(bool inverted)
    {
        if (inverted)
        {
            return invertedImage;
        }
        else
        {
            return image;
        }
    }

    public Sprite GetSprite(bool inverted)
    {
        if (inverted)
        {
            return invertedSprite;
        }
        else
        {
            return sprite;
        }
    }

    public string GetEffect(bool inverted)
    {
        if (inverted)
        {
            return invertedEffect;
        }
        else
        {
            return effect;
        }
    }

    public int GetValue()
    {
        return value;
    }
}
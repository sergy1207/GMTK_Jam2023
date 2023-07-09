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
    bool inverted = false;
    [SerializeField]
    Material image, invertedImage;
    [SerializeField]
    Color color, invertedColor;

    public string GetText()
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

    public Color GetColor()
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

    public Material GetImage()
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

    public int GetValue()
    {
        return value;
    }

    public void Invert()
    {
        inverted = !inverted;
    }
}
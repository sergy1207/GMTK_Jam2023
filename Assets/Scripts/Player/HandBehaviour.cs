using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandBehaviour : MonoBehaviour
{
    [SerializeField] GameObject cardPrefab;
    [SerializeField] int currentCards;
    [SerializeField] float space;
    Transform posRef;

    // Start is called before the first frame update
    void Start()
    {
        posRef = transform.Find("RefPos");

        for (int i = 0; i < 5; i++)
        {
            AddCards(1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AddCards(int num)
    {
        GameObject card = Instantiate(cardPrefab, transform);
        card.transform.localPosition = posRef.localPosition;
        RectTransform cardRect = card.GetComponent<RectTransform>();
        card.transform.localPosition += new Vector3(cardRect.sizeDelta.x/2 + ((cardRect.sizeDelta.x + space) * (transform.childCount - 2)), 0, 0);
    }
}

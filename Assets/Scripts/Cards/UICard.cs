using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UICard : MonoBehaviour
{
    Animator animator;

     public Card card;

    public bool inverted = false;

    public TextMeshProUGUI text;
    Image cardBackground;
    public Image icon;

    /// <summary>
    /// Awake is called when the script instance is being loaded.
    /// </summary>
    void Awake()
    {
        animator = transform.GetComponent<Animator>();    

        text = transform.GetChild(0).Find("Description").GetComponent<TextMeshProUGUI>();
        cardBackground = transform.GetChild(0).Find("Background").GetComponent<Image>();
        icon = transform.GetChild(0).Find("IconBG").GetChild(0).GetComponent<Image>();
    }

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        GetCardInformation();
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if(Input.GetButtonDown("Flip") && animator.GetCurrentAnimatorClipInfo(0)[0].clip.name == "Card_Hover")
        {
            FlipCard();
        }
    }

    #region Animations
    /// <summary>
    /// Se llama al pasar el cursor por encima del a carta de UI
    /// </summary>
    public void Hover()
    {
        animator.SetTrigger("Hover");
        animator.SetBool("Unhover", false);
    }

    /// <summary>
    /// Se llama al sacar el cursor de encima del a carta de UI
    /// </summary>
    public void UnHover()
    {
        animator.SetBool("Unhover", true);
    }

    /// <summary>
    /// Se llama al pulsar la tecla para girar carta de UI
    /// </summary>
    public void FlipCard()
    {
        animator.SetTrigger("Flip");
    }
   
    public void FlipAttributes()
    {
        inverted = !inverted;
        GetCardInformation();
    }
    #endregion



    /// <summary>
    /// Se llama al clicar la carta de UI
    /// </summary>
    public void OnClick()
    {
        animator.enabled = false;
        StartCoroutine(PlayCard(transform.GetChild(0), HandBehaviour.instance.GetCenterPosition()));
    }

    void GetCardInformation()
    {
        text.text = card.GetText(inverted);
        cardBackground.color = card.GetColor(inverted);
        icon.sprite = card.GetSprite(inverted);
    }
    

    IEnumerator PlayCard(Transform cardTransform, Vector3 targetPos)
    {
        Debug.Log("carta jugada");
        Vector3 initPos = cardTransform.position;

        float t = 0;
        while(cardTransform.position != targetPos)
        {
            cardTransform.position = Vector3.Lerp(initPos, targetPos, t);
            t += Time.deltaTime;
            yield return null;
        }
        yield return new WaitForSeconds(.5f);
        Debug.Log(card.GetEffect(inverted) + ":" + card.GetValue().ToString());
        GameManager.instance.Enemy.SendMessage(card.GetEffect(inverted), card.GetValue());

        Destroy(gameObject);

    }
}

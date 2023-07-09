using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UICard : MonoBehaviour
{
    Animator animator;

    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        animator = transform.GetComponent<Animator>();
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
    /// Se llama al clicar la carta de UI
    /// </summary>
    public void OnClick()
    {
        Debug.Log("click");
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
        Debug.Log("Flip");
    }

    
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class LifeBarController : MonoBehaviour
{
    [SerializeField] Image barFill;
    [SerializeField] TextMeshProUGUI healthText;
    
    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        
    }
    
    ///<summary>
    /// actualiza la barra de vida
    ///</summary>
    public void UpdateLifeBar(int health, int maxHealth = 0)
    {
        barFill.fillAmount = health/(float)maxHealth;
        healthText.text = (health.ToString() + "/" + maxHealth.ToString());
    }
}

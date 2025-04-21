using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/*Yasin Shilling
 * 4/20/2025
 * Dictates how the player health bar behaves
 */
public class HealthBar : MonoBehaviour
{
    public PlayerController Health;
    public Image fillImage;
    private Slider slider;
    // Start is called before the first frame update
    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {//shows the players current value in proportion to max health
        float fillvalue = Health.Health/Health.maxHealth;
        slider.value = fillvalue;
    }
}

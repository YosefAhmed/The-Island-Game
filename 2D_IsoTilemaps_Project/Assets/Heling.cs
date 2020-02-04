using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Heling : MonoBehaviour
{
    public Slider healthBar;

    public void Heal(int HealingVal)
    {
        healthBar.value = healthBar.value + HealingVal;
    }
}

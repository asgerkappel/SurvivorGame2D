using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Heal", menuName = "PowerUps/Heal")]

public class Heal : PowerUps
{
    public int amount;

    public override void apply(GameObject target)
    {
        target.GetComponent<Player>().currentHP += amount;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "DamageBonus", menuName = "PowerUps/DamageBonus")]
public class DamageBonus : PowerUps
{
    public int amount;

    public override void apply(GameObject target)
    {
        target.GetComponent<BladeDamage>().damage += amount;
    }
}
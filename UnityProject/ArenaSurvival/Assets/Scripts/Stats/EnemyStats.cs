using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyStats : CharacterStats {

    public override void Die()
    {
        base.Die();

        //add Death animation
        //add Loot/itemdropchance

        Destroy(gameObject);
    }
}

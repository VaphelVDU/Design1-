using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TakeDamage : MonoBehaviour
{
    public int mobHealth = 3;
    public int damageAmount = 1;

    public void TakingDamage(int damageAmount)
    {
        mobHealth = mobHealth - damageAmount;
        Debug.Log("Enemy is taking damage!");

        if (mobHealth < 0)
        {
            Debug.Log("Enemy is dead!");
            Destroy(gameObject);
        }
    }
}

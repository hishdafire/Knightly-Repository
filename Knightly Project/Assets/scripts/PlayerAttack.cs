using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{

    private float timeBetweenAttack;
    public float startTimebetweenAttack;

    public Transform attackPos;
    public LayerMask whatIsEnemies;
    public float attackRange;
    public int damage;

    void Update()
    {
        if(timeBetweenAttack <= 0)
        {   
            if (Input.GetKey(KeyCode.E))
            {
                Debug.Log("attack working");
                Collider2D[] enemiesToDamage = Physics2D.OverlapCircleAll(attackPos.position, attackRange, whatIsEnemies);
                for (int i = 0; i < enemiesToDamage.Length; i++)
                {
                    enemiesToDamage[i].GetComponent<EnemyHealth>().TakeDamage(damage);
                }
                timeBetweenAttack = startTimebetweenAttack;
            }
            
        }
        else
        {
            timeBetweenAttack -= Time.deltaTime;
        }
    }
        
    void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(attackPos.position, attackRange);
    }

}

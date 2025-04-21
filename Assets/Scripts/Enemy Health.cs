using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*Yasin Shilling
 * 4/20/2025
 * Dictates how enemies take damage
 */
public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth;
    public int enemyMaxHealth = 3;
    // Start is called before the first frame update
    private void Start()
    {
        enemyHealth = enemyMaxHealth;
    }
    private void Update()
    {
    if (enemyHealth <= 0)
    { //destroys enemy when health hits 0
       Destroy(gameObject);
    }
    }

    // Update is called once per frame
    public void DamageEnemy(int damageAmount)
    {
        //reduces enemy health
        enemyHealth -= damageAmount;
       
    }
    
        
    }

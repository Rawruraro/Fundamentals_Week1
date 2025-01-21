using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Introduction : MonoBehaviour
{
    public int STR;
    public int VIG;
    public float EnemyHP;
    public float EnemyArmour;
    public float healthPoints;
    public float Damage;
    public float Armour;
    public float DamageDealt;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("What's up world");
        healthPoints = (0.5f * STR + VIG); //if using a float or decimal, put f at the end.
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space)) //when spacebar is pressed, call function TakeDamage
        {
            TakeDamage();
        }

        if (Input.GetKeyDown(KeyCode.F)) //most inputs only require it to be typed like this. capital key.
        {
            DealDamage();
        }
    }

    void TakeDamage()
    {
        healthPoints -= Damage - Armour;
        DamageDealt = Damage - Armour;
        Debug.Log("You took " + DamageDealt + " Damage!");
        if (healthPoints <= 0)
        {
            Debug.Log("You died!");
            healthPoints = 0;
        }

    }

    void DealDamage()
    {
        EnemyHP -= STR - EnemyArmour;
        DamageDealt = STR - EnemyArmour;
        Debug.Log("You dealt " + DamageDealt + " Damage!");

        if (EnemyHP <= 0)
        {
            Debug.Log("You win!");
            EnemyHP = 0;
        }
    }
}

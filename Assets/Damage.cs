using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int attackDamage = 1;
    public string opponent;

    Health health;
    GameObject player;
    bool InRange;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(opponent);
        health = player.GetComponent<Health>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
            InRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        InRange = false;
    }

    void Update()
    {
        if (InRange)
            Attack();
    }

    void Attack()
    {
        if (health.CurrentHealth > 0)
            health.TakeDamage(attackDamage);
    }
}

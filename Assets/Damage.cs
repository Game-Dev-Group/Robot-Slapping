using System.Collections;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public int attackDamage = 1;
    public string opponent;

    Health opponentHealth;
    Health playerHealth;
    GameObject player;
    bool InRange;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(opponent);
        opponentHealth = player.GetComponent<Health>();
        playerHealth = GetComponent<Health>();
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player)
            InRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            InRange = false;
    }

    void Update()
    {
        if (InRange && opponentHealth.CurrentHealth > 0)
            Attack();
    }

    void Attack()
    {
        if (opponentHealth.CurrentHealth > 0)
            opponentHealth.TakeDamage(attackDamage);
    }
}

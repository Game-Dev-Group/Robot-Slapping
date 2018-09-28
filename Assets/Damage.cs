using System.Collections;
using System.Threading;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float attackDelay;
    public int attackDamage;
    public string opponent;

    Health opponentHealth;
    GameObject player;
    bool InRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(opponent);
        opponentHealth = player.GetComponent<Health>();
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
        timer += Time.deltaTime;
        if (timer >= attackDelay && InRange)
            Attack();
    }

    void Attack()
    {
        timer = 0f;

        if (opponentHealth.CurrentHealth > 0)
            opponentHealth.TakeDamage(attackDamage);
    }
}

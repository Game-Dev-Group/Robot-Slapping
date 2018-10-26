using System;
using System.Collections;
using System.Threading;
using UnityEngine;

public class Damage : MonoBehaviour
{
    public float attackDelay;
    public int attackDamage;
    public string opponent;
    public bool isBlocked;

    Health opponentHealth;
    GameObject player;
    bool InRange;
    float timer;

    void Awake()
    {
        player = GameObject.FindGameObjectWithTag(opponent);
        opponentHealth = player.GetComponent<Health>();
        isBlocked = false;
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == player && !isBlocked)
            InRange = true;
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject == player)
            InRange = false;
    }

    void Update()
    {
        isBlocked = HurtBoxMovement.isBlocked;
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

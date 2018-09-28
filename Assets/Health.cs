using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthSlider;

    public int MaxHealth = 10;
    public int CurrentHealth;

    Movement movement;
    HurtBoxMovement hurtBoxMovement;
    bool isDead;
    bool damaged;

    void Awake()
    {
        movement = GetComponent<Movement>();
        hurtBoxMovement = GetComponent<HurtBoxMovement>();

        CurrentHealth = MaxHealth;
    }

    void Update()
    {
        damaged = false;
    }

    public void TakeDamage(int amount)
    {
        damaged = true;

        CurrentHealth -= amount;
        healthSlider.value = CurrentHealth;


        if (CurrentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        movement.enabled = false;
        hurtBoxMovement.enabled = false;
    }
}

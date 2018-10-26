using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public Slider healthSlider;
    public int MaxHealth;
    public int CurrentHealth;
    public string player;

    GameObject me;
    bool isDead;
    bool damaged;

    void Awake()
    {
        me = GameObject.FindGameObjectWithTag(player);
        CurrentHealth = MaxHealth;
        isDead = false;
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

        me.SetActive(false);
    }
}

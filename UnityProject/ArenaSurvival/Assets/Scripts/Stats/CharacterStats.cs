
using UnityEngine;

public class CharacterStats : MonoBehaviour {


    public float maxHealth = 10f;
    public float currentHealth { get; private set; } //Any other class can get this value, but can only be set within this class

    public Stat damage;
    public Stat armor;

    void Awake()
    {
        currentHealth = maxHealth;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(1);
        }

    }

    public void TakeDamage(int damage)
    {
        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue); // Makes it so you can't take negative damage (heal form damage taken)

        currentHealth -= damage;
        Debug.Log(transform.name + "takes" + damage + "damage.");

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    public virtual void Die()
    {
        Debug.Log(transform.name + "died");
    }

}

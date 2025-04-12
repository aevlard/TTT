using UnityEngine;

public class MeteorBase : MonoBehaviour
{
    [SerializeField] int health = 20;

    public int Health
    {
        get => health;
        set => health = value;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        CheckIfAlive();
    }

    private void CheckIfAlive()
    {
        if (health <= 0)
        {
            DeathHandler();
        }
    }

    private void DeathHandler()
    {
        Destroy(gameObject);
    }
    
}

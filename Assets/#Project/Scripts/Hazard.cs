using Unity.VisualScripting;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    [SerializeField] int damage;

    

    void OnTriggerEnter(Collider other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.current -= damage;
            GameStats.totalDamage += damage;
            
            GameStats.PrintTotalDamage();

            // health.TakeDamage(damage);
        }

        // Alternative:    
        // Health health;
        // if (other.TryGetComponent<Health>(out health))
        // {
            
        // }
    
    }


}

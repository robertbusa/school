using UnityEngine;

public class Damager : MonoBehaviour
    {
    [SerializeField] int damage;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Damageable damageable = other.GetComponent<Damageable>();
            // Amikor megtörténik az ütközés akkor paraméterben átadja a másik kkomponenst ami other és ha van ilyen komponens, akkor...
    if(damageable != null)
        {
            Debug.Log($"Collided with {damageable.name}");
            damageable.Damage(damage);
        }
    }
}


using UnityEngine;

public class Damager : MonoBehaviour
    {
    [SerializeField] int damage;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision");
        Damageable damageable = other.GetComponent<Damageable>();
            // Amikor megt�rt�nik az �tk�z�s akkor param�terben �tadja a m�sik kkomponenst ami other �s ha van ilyen komponens, akkor...
    if(damageable != null)
        {
            Debug.Log($"Collided with {damageable.name}");
            damageable.Damage(damage);
        }
    }
}


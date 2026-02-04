using UnityEngine;

public class SpikeTrap : MonoBehaviour
{
    [SerializeField] float damage = 10f;

    void OnTriggerStay2D(Collider2D other)
    {
        if(other.TryGetComponent(out iDamageable damageable))
        {
            damageable.ApplyDamage(damage);
        }
    }
}
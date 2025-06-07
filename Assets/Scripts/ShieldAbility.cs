using UnityEngine;
using UnityEngine.Events;

public class ShieldAbility : MonoBehaviour
{   
    public UnityEvent shieldobtained;
    private void OnTriggerEnter2D(Collider2D other)
    {
        var iscar = other.GetComponent<Movement>() != null;
        if (!iscar) return;

        shieldobtained.Invoke();
        
        Destroy(this.gameObject);
    }
}

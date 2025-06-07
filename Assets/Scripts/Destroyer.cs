using UnityEngine;
using UnityEngine.Events;

public class Destroyer : MonoBehaviour
{
    public UnityEvent onhit;
    private void OnCollisionEnter2D(Collision2D other)
    {
        GameObject otherObject = other.gameObject;

        if (otherObject.name.Contains("Stone"))
        {
            Destroy(otherObject);
            onhit.Invoke();
        }
        else if (otherObject.name.Contains("Sign"))
        {
            Destroy(otherObject);
            onhit.Invoke();
        }
    }
}

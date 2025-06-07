using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class Health : MonoBehaviour
{
    int hpamount = 3;
    public TMP_Text hpcount;
    private bool shieldactive = false;
    public UnityEvent currenthealth;

    void Update()
    {
        if (hpamount == 0)
        {
            currenthealth.Invoke();
        }
    }

    public void UpdateHealthCount()
    {
        if (shieldactive == false)
        {
            hpamount--;
        }
        else
        {
            shieldactive = false;
        }

        hpcount.text = "" + hpamount;
    }

    public void hasshield()
    {
        shieldactive = true;
    }
}

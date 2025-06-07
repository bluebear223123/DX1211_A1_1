using TMPro;
using UnityEngine;

public class Health : MonoBehaviour
{
    int hpamount = 3;
    public TMP_Text hpcount;
    private bool shieldactive = false;

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

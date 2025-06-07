using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    private float elapsedTime = 0.0f;
    public TMP_Text Scoretext;

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        Scoretext.text = "" + elapsedTime;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTrigger2 : MonoBehaviour
{
    public TextMeshProUGUI Score2;
    static int scoreTwo = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Ball")
            scoreTwo++;
        Debug.Log("Score2");
        Score2.text = scoreTwo.ToString();
    }
}

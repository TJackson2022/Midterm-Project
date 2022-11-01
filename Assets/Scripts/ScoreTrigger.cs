using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreTrigger : MonoBehaviour
{
    public TextMeshProUGUI Score1;
    static int scoreOne = 0;
    private void OnTriggerEnter (Collider other)
    {
        if (other.tag == "Ball")
            scoreOne++;
        Debug.Log("Score1");
        Score1.text = scoreOne.ToString();
    }
}

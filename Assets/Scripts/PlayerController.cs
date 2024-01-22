using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public int score;

    public TMPro.TextMeshProUGUI scoreCounterText;

    private void OnMouseDown()
    {
        OnPlayerClicked(); 
    }

    void OnPlayerClicked()
    {
        score++;
        scoreCounterText.text = "Score:" + score.ToString();
    }
}

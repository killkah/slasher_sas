using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Click : MonoBehaviour
{
    public int score;
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    public void Clicks()
    {
        score++;
        scoreText.text = score.ToString();
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

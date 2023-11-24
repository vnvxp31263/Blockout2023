using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
// using TMPro;

public class DrawScore : MonoBehaviour
{
    Text scoreText;
    [SerializeField] private string searchText;

    // Start is called before the first frame update
    void Start()
    {
        // scoreTextÇSerializeFieldÇÃílÇ≈èâä˙âª
        scoreText = GameObject.Find(searchText).GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        scoreText.text = "Score:" + Score.score.ToString();
    }

    public void OnClickToGame()
    {
        if (SceneManager.GetActiveScene().name == "Main")
        {
            SceneManager.LoadScene("Result");
        }
        else
        {
            Score.score = 0;
            SceneManager.LoadScene("Title");
        }
    }
}
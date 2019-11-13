using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Text message;
    //public Text input1;
    private InputField input;

    private void Awake()
    {
        input = GameObject.Find("InputField").GetComponent<InputField>();
    }

    string ans = "history is written by victors";
    public void GetInput(string guess)
    {
        //Debug.Log(guess);
        if(guess.ToLower() == ans)
        {
            //Debug.Log("AREY TUM KRISHAN HO KYA?");
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        else
        {
            Debug.Log("Bhak sala chutiya !!");
            message.text = "TRY HARDER...";
        }
        input.text = "";
    }
}

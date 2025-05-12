using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UIElements;

public class gamecontroller : MonoBehaviour
{
    public string Word = "after";
    public int LivesCount = 10;
    public TextMeshProUGUI MainWord;
    public TextMeshProUGUI SuggestionText;
    public TMP_InputField InputField;
    public TextMeshProUGUI OurInput;


    // Start is called before the first frame update
    void Start()
    {
        MainWord.text = Word;
        OurInput.text = $"Zostalo prób: {LivesCount} ";
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInputChanged(string input)
    {

        OurInput.text = input;

    }
    public void OnClick()
    {
        Debug.Log($"Przycisk klikniety");
        LivesCount = LivesCount - 1;
        OurInput.text = $"Zostalo prób: {LivesCount} ";

        if (Word == InputField.text)
        {
            Debug.Log($"Poprawna odpowiedz");
            //TODO Change text on canvas
            return;
        }
        if (Word.Length != InputField.text.Length)
        {
            SuggestionText.text = $"Dlugosc sie nie zgadza";
            return;
        }

        int bullsCount = CountBulls();
        int cowsCount = CountCows();

        SuggestionText.text = $"Bulls: {bullsCount} and Cows: {cowsCount}";
    }
    public int CountBulls()
    {
        int result = 0;

        for (int i = 0; i < Word.Length; i++)
        {
            // || (or) =>conajmniej jedna ze stron jest true => true, else false
            //&& (and) warunki po lewej i prawej powinny byc true => true, else false
           if (Word[i] != InputField.text[i] && Word.Contains(InputField.text[i]))
            {
                result++;
            }
             
        }

        return result;
    }
    
    public int CountCows()       
    {
        return 0;
    }
}

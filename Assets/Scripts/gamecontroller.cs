using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class gamecontroller : MonoBehaviour
{
    public string slowo = "zdanie";
    public TextMeshProUGUI MainZdanie;
   public TMP_InputField InputField;
    public TextMeshProUGUI OurInput;


    // Start is called before the first frame update
    void Start()
    {
        MainZdanie.text = slowo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnInputChanged(string input)
    {

        OurInput.text = input;

    }
}
s
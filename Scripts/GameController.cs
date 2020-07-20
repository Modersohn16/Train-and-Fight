using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    public float PushUpNumberToLvl = 110f;
    
    public InputField input;
    float abc = 0;
    public Text StrText;
    public Text StrText2;
    public float currentStrLvl = 0;
    public Text PushUpsTotalNumber;
    public Text PushUpNumberToLvlText;

    void Start()
    {
        // PlayerPrefs.DeleteAll();
        StrText.text = currentStrLvl.ToString();
        abc = PlayerPrefs.GetFloat("PushUpsTotalNumber"); // LOAD
        currentStrLvl = PlayerPrefs.GetFloat("CurrentSTRlevel"); // LOAD
        PushUpNumberToLvl = currentStrLvl * 110;


    }

    public void DeleteAllPrefs()
    {

        PlayerPrefs.DeleteAll();
        abc = PlayerPrefs.GetFloat("PushUpsTotalNumber");
        currentStrLvl = PlayerPrefs.GetFloat("CurrentSTRlevel") + 1;
        PushUpNumberToLvl = 110f;
        PlayerPrefs.SetFloat("PushUpsTotalNumber", abc);
        PlayerPrefs.SetFloat("CurrentSTRlevel", currentStrLvl);
        PlayerPrefs.SetFloat("PushUpNumberToLvl", PushUpNumberToLvl);

    }

    public void GetInput(string PushUpNumber)
    {
        Debug.Log("You entered " + PushUpNumber);
        abc = abc + float.Parse(PushUpNumber);
        PlayerPrefs.SetFloat("PushUpsTotalNumber", abc);  // SAVE

       Debug.Log("wynik " + abc);
        PushUpNumber = "0";
    }

    void Update()
    {
        PushUpsTotalNumber.text = abc.ToString();
        PushUpNumberToLvlText.text = PushUpNumberToLvl.ToString();
        StrText.text = currentStrLvl.ToString();
        StrText2.text = currentStrLvl.ToString();

        if (abc > PushUpNumberToLvl)

        {
            PushUpsTotalNumber.text = abc.ToString();
            PushUpNumberToLvlText.text = PushUpNumberToLvl.ToString();
            currentStrLvl = currentStrLvl + 1;
            PlayerPrefs.SetFloat("CurrentSTRlevel", currentStrLvl);  // SAVE

            StrText.text = currentStrLvl.ToString();
            StrText2.text = currentStrLvl.ToString();
            PushUpNumberToLvl = currentStrLvl * 110;
            PlayerPrefs.SetFloat("PushUpNumberToLvl", PushUpNumberToLvl);
        }
    }


    

}

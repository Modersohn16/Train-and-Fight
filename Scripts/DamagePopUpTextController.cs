using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagePopUpTextController : MonoBehaviour {

    private static DamagePopUpText popUpText;
    private static GameObject canvas;


    public static void Initialize()
    {
        canvas = GameObject.Find("PopupCanvas");
        if(!popUpText)
        popUpText = Resources.Load<DamagePopUpText>("PopupTextParent");
    }
    public static void CreateFloatingText(string text, Transform location)
    {
        DamagePopUpText instance = Instantiate(popUpText);
       Vector2 screenPosition = Camera.main.WorldToScreenPoint(location.position);
        instance.transform.SetParent(canvas.transform, false);
       instance.transform.position = screenPosition;
        instance.SetText(text);
    }
}

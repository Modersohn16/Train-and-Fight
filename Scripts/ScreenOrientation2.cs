using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class ScreenOrientation2 : MonoBehaviour {

    void Awake()
    {
        Screen.orientation = ScreenOrientation.LandscapeLeft;
        Screen.autorotateToPortraitUpsideDown = false;
        Screen.autorotateToLandscapeRight = true;
        Screen.autorotateToLandscapeLeft = true;
        Screen.autorotateToPortrait = false;
    }
}

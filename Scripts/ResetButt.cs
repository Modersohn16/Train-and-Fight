using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetButt : MonoBehaviour
{

    public GameController gameController;

    public void ResetPrefs()
    {
        gameController.DeleteAllPrefs();
    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiftClick : MonoBehaviour
{
    public LiftAnimation liftScript;
    private void OnMouseDown()
    {
        liftScript.buttonPressed = true;
    }
}

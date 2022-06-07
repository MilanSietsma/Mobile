using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyGameManager : MonoBehaviour
{

    /// <summary>
    /// Called when the application pauses.
    /// </summary>
    /// <param name="pause"><c>true</c> if the application is paused, else <c>false</c>.</param>
    private static void OnApplicationPause(bool pause)
    {
        if (pause)
        { }
    }


    /// <summary>
    /// Called when the gamme loses or gains focus. 
    /// </summary>
    /// <param name="hasFocus"><c>true</c> if the gameobject has focus, else <c>false</c>.</param>
    /// <remarks>
    /// On Windows Store Apps and Windows Phone 8.1 there's no application quit event,
    /// consider using OnApplicationFocus event when hasFocus equals false.
    /// </remarks>
    void OnApplicationFocus(bool hasFocus)
    {
        if (!hasFocus) { }
    }


    /// <summary>
    /// Called before the application quits.
    /// </summary>
    /// <remarks>
    /// iOS applications are usually suspended and do not quit.
    /// On Windows Store Apps and Windows Phone 8.1 there's no application quit event,
    /// consider using OnApplicationFocus event when focusStatus equals false.
    /// On WebGL is not possible to implement OnApplicationQuit due to nature of the
    /// browser tabs closing.
    /// </remarks>
    private void OnApplicationQuit()
    {
        // Note that we do not get an OnApplicationQuit event on iOS devices. We
        // therefore saves the data in the OnApplicationPause and OnApplicationFocus
        // events, and have this code just in case:

    }
}
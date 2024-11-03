using System;
using UnityEngine;
using UnityEngine.UI; // Importar UnityEngine.UI
using UnityStandardAssets.CrossPlatformInput;

[RequireComponent(typeof(RawImage))] // Cambiado a RawImage
public class ForcedReset : MonoBehaviour
{
    private void Update()
    {
        // if we have forced a reset ...
        if (CrossPlatformInputManager.GetButtonDown("ResetObject"))
        {
            //... reload the scene
            UnityEngine.SceneManagement.SceneManager.LoadSceneAsync(UnityEngine.SceneManagement.SceneManager.GetActiveScene().name); // Uso actualizado
        }
    }
}


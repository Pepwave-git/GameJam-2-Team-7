using UnityEngine;
using UnityEngine.UI;

public class DialogController : MonoBehaviour
{
    public GameObject dialogPanel;
    public KeyCode closeKey = KeyCode.E; // Puedes cambiar 'Space' por la tecla que prefieras

    void Start()
    {
        ShowDialog();
    }

    void Update()
    {
        if (Input.GetKeyDown(closeKey))
        {
            HideDialog();
        }
    }

    public void ShowDialog()
    {
        dialogPanel.SetActive(true);
    }

    public void HideDialog()
    {
        dialogPanel.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Disco : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        PlayerInput.Instance.OnInteractionPressed += Instance_OnInteractionPressed;
        Show();
    }

    private void Instance_OnInteractionPressed(object sender, System.EventArgs e)
    {
        Hide();
        PlayerInput.Instance.OnInteractionPressed -= Instance_OnInteractionPressed;
    }

    private void Show()
    {
        gameObject.SetActive(true);
    }

    private void Hide()
    {
        gameObject.SetActive(false);
    }
}

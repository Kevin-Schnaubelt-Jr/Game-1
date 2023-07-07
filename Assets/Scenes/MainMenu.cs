using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // For SceneManager
using UnityEngine.UIElements; // For VisualElement

public class MainMenu : MonoBehaviour
{
    Button button;

    private void OnEnable() 
    {
        UIDocument ui = GetComponent<UIDocument>();
        VisualElement root = ui.rootVisualElement;

        button = root.Q<Button>("play-button");

        button.RegisterCallback<ClickEvent>(ButtonClicked);
    }

    void ButtonClicked(ClickEvent evt) 
    {
        Debug.Log("Button Clicked");
        SceneManager.LoadScene(1);
    }

        
}

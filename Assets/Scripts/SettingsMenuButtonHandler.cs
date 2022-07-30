using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// TODO: Remove this class
public class SettingsMenuButtonHandler : MonoBehaviour
{
  private GameObject SettingsMenu;
  private Button Button;

  // Start is called before the first frame update
  void Start()
  {
    Button = gameObject.GetComponent<Button>();
    SettingsMenu = GameObject.Find("SettingsMenu");

    // Add button listener
    Button.onClick.AddListener(HandleSettingsClick);
  }

  void HandleSettingsClick()
  {
    SettingsMenu.GetComponentInChildren<Canvas>().enabled = false;

    // Show the main menu when the settings menu is closed
    var menu = GameObject.Find("SceneLoader").GetComponentInChildren<Canvas>();
    menu.enabled = true;
  }
}

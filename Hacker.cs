using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    //game state
    int level;
    enum Screen {MainMenu, password, Win};
    Screen CurrentScreen = Screen.MainMenu;

    // Start is called before the first frame update
    void Start()
    {
      ShowMainMenu();
    }

    void ShowMainMenu (){
      CurrentScreen = Screen.MainMenu;
      Terminal.ClearScreen();
      Terminal.WriteLine("what would you like to hack into?");
      Terminal.WriteLine("press 1 for the local library");
      Terminal.WriteLine("press 2 for the police station");
      Terminal.WriteLine("Enter your selection:");
    }

    void OnUserInput(string input){
        if (input == "menu") {
          ShowMainMenu();
        }
        else if (CurrentScreen == Screen.MainMenu) {
          RunMainMenu(input);
        }
    }

    void RunMainMenu(string input){
        if (input == "2") {
          level = 2;
          StartGame();
        }
        else if (input == "1") {
          level = 1;
          StartGame();
        }
        else{
          Terminal.WriteLine("please choose a valid level");
        }
    }

    void StartGame (){
      CurrentScreen = Screen.password;
      Terminal.WriteLine("you have chosen level " + level);
      Terminal.WriteLine("please enter your password");
    }

    // Update is called once per frame
    void Update()
    {

    }
}

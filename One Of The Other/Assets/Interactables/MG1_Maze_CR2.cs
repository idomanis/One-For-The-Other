using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MG1_Maze_CR2 : Interactable
{
    // Start is called before the first frame update
    protected override void Interact()
    {
        SceneManager.LoadScene(2);
    }
}

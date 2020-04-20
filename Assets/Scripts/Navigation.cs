using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Navigation : MonoBehaviour
{
    // Start is called before the first frame update
    public string GoToPage;

    public void GoTo()
    {
        SceneManager.LoadScene(GoToPage);
    }
}

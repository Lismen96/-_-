using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnKeyPress : MonoBehaviour
{
    [SerializeField] private string sceneToLoad = "MainMenu"; 
    [SerializeField] private KeyCode keyToPress = KeyCode.R;

    void Update()
    {

        if (Input.GetKeyDown(keyToPress))
        {

            LoadScene();
        }
    }

    private void LoadScene()
    {

        SceneManager.LoadScene(sceneToLoad);
    }
    private void UnlockCursor()
    {
        Time.timeScale = 1f;
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
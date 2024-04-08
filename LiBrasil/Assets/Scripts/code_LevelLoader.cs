using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class code_LevelLoader : MonoBehaviour
{
    [SerializeField] float transitionTime;
    Animator transition;

    void Start()
    {
        transition = GetComponentInChildren<Animator>();
    }

    public void LoadNextLevel(int index)
    {
        StartCoroutine(LoadLevel(index));
    }

    IEnumerator LoadLevel(int index)
    {
        if (transition != null)
        {
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(index);
        }
        else
        {
            transition.SetTrigger("Start");
            yield return new WaitForSeconds(transitionTime);
            SceneManager.LoadScene(index);
        }

        Time.timeScale = 1;
    }

    public void ReloadScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
}
using UnityEngine;

public class code_Management : MonoBehaviour
{
    [SerializeField] private GameObject menuCanvas;
    [SerializeField] private GameObject settingsCanvas;
    [SerializeField] private GameObject librasCanvas;

    private void Start()
    {
        ActivateMenuCanvas();
    }

    public void ActivateMenuCanvas()
    {
        ToggleCanvas(menuCanvas);
    }

    public void ActivateSettingsCanvas()
    {
        ToggleCanvas(settingsCanvas);
    }

    public void ActivateLibrasCanvas()
    {
        ToggleCanvas(librasCanvas);
    }

    private void ToggleCanvas(GameObject canvas)
    {
        menuCanvas.SetActive(canvas == menuCanvas);
        settingsCanvas.SetActive(canvas == settingsCanvas);
        librasCanvas.SetActive(canvas == librasCanvas);
    }

    public void OnExit()
    {
        Application.Quit();
    }
}

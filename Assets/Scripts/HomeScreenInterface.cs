using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeScreenInterface : MonoBehaviour
{   
    [SerializeField] public GameObject HomeScreenCanvas;
	[SerializeField] public GameObject TutorialCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        HomeScreenCanvas.SetActive(true);
        TutorialCanvas.SetActive(false);
        Debug.Log("loaded");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void HomeScreenToTutorial()
    {
        HomeScreenCanvas.SetActive(false);
        TutorialCanvas.SetActive(true);
        Debug.Log("homescreen to tutorial");
    }

    public void TutorialToMainExperience()
    {
        SceneManager.LoadScene("SliderScene"); 
        Debug.Log("tutorial to experience"); 
    }
}

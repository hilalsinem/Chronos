using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoControl : MonoBehaviour
{
    public VideoPlayer videoPlayer; // Reference to the VideoPlayer component
    public Button nextSceneButton;  // Reference to the Button

    void Start()
    {
        nextSceneButton.gameObject.SetActive(false);  // Hide button initially

        // Subscribe to the video player's completed event
        videoPlayer.loopPointReached += OnVideoEnd;
    }

    // This function is called when the video ends
    void OnVideoEnd(VideoPlayer vp)
    {
        nextSceneButton.gameObject.SetActive(true);  // Show the button when the video finishes
    }

    // Assign this function to the Button's OnClick event in the Inspector
    public void LoadNextScene()
    {
        SceneManager.LoadScene("NextScene");  // Replace "NextScene" with your actual scene name
    }
}

using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class QuizManager : MonoBehaviour
{
    public Button letsGoButton;
    public Button noThanksButton;

    // Start is called before the first frame update
    void Start()
    {
        // Hook events
        letsGoButton.onClick.AddListener(StartQuiz);
        noThanksButton.onClick.AddListener(BackToMainMenu);
    }

    public void StartQuiz()
    {
        // You can add any additional logic here before starting the quiz
        SceneTransitionManager.singleton.GoToSceneAsync(3); // Change to the quiz scene index
        SceneManager.LoadScene(3);
    }

    public void BackToMainMenu()
    {
        // You can add any cleanup logic here if needed
        SceneTransitionManager.singleton.GoToSceneAsync(0); // Change to the main menu scene index
    }
}

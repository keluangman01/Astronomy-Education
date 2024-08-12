using UnityEngine;
using UnityEngine.SceneManagement;

public class QuizButtonManager : MonoBehaviour
{
    public void StartQuiz()
    {
        // Load the quiz scene (change "QuizScene" to your actual quiz scene name)
        SceneManager.LoadScene("2");
    }

    public void NoThanks()
    {
        // The "No Thanks" button does nothing when clicked
    }
}

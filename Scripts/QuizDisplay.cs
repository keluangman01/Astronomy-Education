using UnityEngine;
using UnityEngine.UI;

public class QuizDisplay : MonoBehaviour
{
    public Text questionText;
    public string[] questions; // Array of quiz questions

    private int currentQuestionIndex = 0;

    void Start()
    {
        DisplayQuestion();
    }

    void Update()
    {
        // You can add logic here to handle user input, such as advancing to the next question
        // For example, you might want to listen for a button press or a certain event
        // and call DisplayQuestion() when you want to show the next question.
    }

    void DisplayQuestion()
    {
        // Ensure the current index is within the bounds of the questions array
        if (currentQuestionIndex < questions.Length)
        {
            // Display the current question on the RawImage component
            questionText.text = questions[currentQuestionIndex];
        }
        else
        {
            // If there are no more questions, display a message or perform other actions
            questionText.text = "Quiz Completed!";
        }
    }
}

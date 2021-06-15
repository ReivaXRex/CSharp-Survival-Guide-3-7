using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCalculator : MonoBehaviour
{
    int QuizGrade1, QuizGrade2, QuizGrade3, QuizGrade4, QuizGrade5;
    int totalQuizGrade;
    int averageMark;

    // Start is called before the first frame update
    void Start()
    {
        // Set the QuizGrade values to a random number between 0-100.
        QuizGrade1 = Random.Range(0, 100);
        QuizGrade2 = Random.Range(0, 100);
        QuizGrade3 = Random.Range(0, 100);
        QuizGrade4 = Random.Range(0, 100);
        QuizGrade5 = Random.Range(0, 100);

        // Add together all the values of the Quiz Grades.
        totalQuizGrade = QuizGrade1 + QuizGrade2 + QuizGrade3 + QuizGrade4 + QuizGrade5;
        
        // Calculate the average by dividing the total QuizGrade by the number of quizzes(5).
        averageMark = totalQuizGrade / 5;

        // Display the value of the quizzes to the Console.
        Debug.Log("Your mark for Quiz 1 was " + QuizGrade1);
        Debug.Log("Your mark for Quiz 2 was " + QuizGrade2);
        Debug.Log("Your mark for Quiz 3 was " + QuizGrade3);
        Debug.Log("Your mark for Quiz 4 was " + QuizGrade4);
        Debug.Log("Your mark for Quiz 5 was " + QuizGrade5);

        // Display the average mark of the quizzes to the Console.
        Debug.Log("Your average mark across the five Quizzes was " + averageMark);
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizAverage : MonoBehaviour
{
    //  Create average random quiz scores. Assign the scores pass or fail using a conditional statement.

    int QuizGrade1, QuizGrade2, QuizGrade3, QuizGrade4, QuizGrade5;
    int totalQuizGrade;
    int averageMark;
    int markA = 90;
    int markB = 80;
    int markC = 70;

    void Start()
    {
        QuizGrade1 = Random.Range(0, 101);
        QuizGrade2 = Random.Range(0, 101);
        QuizGrade3 = Random.Range(0, 101);
        QuizGrade4 = Random.Range(0, 101);
        QuizGrade5 = Random.Range(0, 101);

        totalQuizGrade = QuizGrade1 + QuizGrade2 + QuizGrade3 + QuizGrade4 + QuizGrade5;
        averageMark = totalQuizGrade / 5;

        Debug.Log("Your mark for Quiz 1 was " + QuizGrade1);
        Debug.Log("Your mark for Quiz 2 was " + QuizGrade2);
        Debug.Log("Your mark for Quiz 3 was " + QuizGrade3);
        Debug.Log("Your mark for Quiz 4 was " + QuizGrade4);
        Debug.Log("Your mark for Quiz 5 was " + QuizGrade5);

        Debug.Log("Your average mark across the five Quizzes was " + averageMark);

        if (averageMark >= markA) // If the averageMark is greater than or equal to 90.
        {
            Debug.Log("Your grade average is an 'A'.");
        }
        else if (averageMark >= markB && averageMark < markA) // If the averageMark is greater than or equal to 80 and less than 90.
        {
            Debug.Log("Your grade average is a 'B'.");
        }
        else if (averageMark >= markC && averageMark < markB) // If the averageMark is greater than or equal to 70 and less than 80.
        {
            Debug.Log("Your grade average is a 'C'.");
        }
        else 
        {
            Debug.Log("Your grade average is below a 'C'.");
        }
    }
}

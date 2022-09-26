  using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "QiuzQuestions", fileName = "New Question")]
public class QuizQuestions : ScriptableObject
{
    [TextArea(2,6)]
    [SerializeField] public string Question = "Enter new Question";
    [SerializeField] string[] Answer = new string[4];
    [SerializeField] int correctAnswerIndex;

    public string getQuestion()
    {
        return Question;
    }
    public int GetCorrectAnswerIndex()
    {
        return correctAnswerIndex;
    }

    public string GetAnswer(int index)
    {
        return Answer[index];
    }
}

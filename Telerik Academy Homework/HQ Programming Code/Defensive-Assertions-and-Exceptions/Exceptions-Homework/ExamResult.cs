using System;

public class ExamResult
{
    public int Grade { get; private set; }
    public int MinGrade { get; private set; }
    public int MaxGrade { get; private set; }
    public string Comments { get; private set; }

    public ExamResult(int grade, int minGrade, int maxGrade, string comments)
    {
        if (grade < 0)
        {
            throw new ArgumentOutOfRangeException("The grade cannot be less than zero!");
        }
        if (minGrade < 0)
        {
            throw new ArgumentOutOfRangeException("The minimum grade cannot be less than zero!");
        }
        if (maxGrade <= minGrade)
        {
            throw new ArgumentOutOfRangeException("The maximum grade cannot be less or equal to minimum grade!");
        }
        if (comments == null || comments == "")
        {
            throw new ArgumentNullException("You must enter a comment!");
        }

        this.Grade = grade;
        this.MinGrade = minGrade;
        this.MaxGrade = maxGrade;
        this.Comments = comments;
    }
}

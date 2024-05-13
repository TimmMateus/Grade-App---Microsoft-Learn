public class GradeCalculation
{
    static public void calculateScore(Student student, int examAssignments){
        int[] grade = student.getGrade();
        int sumExamScores = 0;
        int gradedAssignments = 0;
        int sumExtraCreditScores = 0;
        int gradedExtraCreditAssignments = 0;

        foreach(int gradeItem in grade){
            gradedAssignments += 1;
            if(gradedAssignments <= examAssignments)
                sumExamScores += gradeItem;
            else
            {
                gradedExtraCreditAssignments++;
                sumExtraCreditScores += gradeItem;
            }
        }

        student.setExamScore((decimal)sumExamScores/examAssignments);
        student.setExtraCredit((decimal)sumExtraCreditScores/(10*examAssignments));
        student.setExtraCreditScores((decimal)sumExtraCreditScores/gradedExtraCreditAssignments);
        student.setTotalScore(student.getExamScore()+student.getExtraCredit());
        letterGradeAssignemnt(student);
    }

    static public void letterGradeAssignemnt(Student student){
        decimal totalScore = student.getTotalScore();
        if (totalScore >= 97)
            student.setLetterGrade("A+");

        else if (totalScore >= 93)
            student.setLetterGrade("A");

        else if (totalScore >= 90)
            student.setLetterGrade("A-");

        else if (totalScore >= 87)
            student.setLetterGrade("B+");

        else if (totalScore >= 83)
            student.setLetterGrade("B");

        else if (totalScore >= 80)
            student.setLetterGrade("B-");

        else if (totalScore >= 77)
            student.setLetterGrade("C+");

        else if (totalScore >= 73)
            student.setLetterGrade("C");

        else if (totalScore >= 70)
            student.setLetterGrade("C-");

        else if (totalScore >= 67)
            student.setLetterGrade("D+");

        else if (totalScore >= 63)
            student.setLetterGrade("D");

        else if (totalScore >= 60)
            student.setLetterGrade("D-");

        else
            student.setLetterGrade("F");
    }
}

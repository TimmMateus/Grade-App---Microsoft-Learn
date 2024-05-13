public class Student
{
    private String name;
    private int[] grade;
    private decimal examScore;
    private decimal extraCreditScore;
    private decimal extraCredit;
    private decimal totalScore;
    private String letterGrade = "";

    public Student(String name, int[] grade)
    {
        this.name = name;
        this.grade = grade;
    }
    public void setExamScore(decimal examScore){
        this.examScore = examScore;
    }
    public void setExtraCreditScores(decimal extraCreditScore){
        this.extraCreditScore = extraCreditScore;
    }
    public void setExtraCredit(decimal extraCredit){
        this.extraCredit = extraCredit;
    }
    public void setTotalScore(decimal totalScore) {
        this.totalScore = totalScore;
    }
    public void setLetterGrade(String letterGrade) {
        this.letterGrade = letterGrade;
    }
    public String getName(){
        return name;
    }
    public int[] getGrade(){
        return grade;
    }
    public decimal getExamScore(){
        return examScore;
    }
    public decimal getExtraCredit(){
        return extraCredit;
    }
    public decimal getTotalScore(){
        return totalScore;
    }
    public decimal getExtraCreditScore(){
        return extraCreditScore;
    }
    public String getLetterGrade(){
        return letterGrade;
    }
    public void printStudent(){
        Console.WriteLine($"{name}\t\t{examScore}\t\t{totalScore}\t{letterGrade}\t{extraCreditScore}({extraCredit} pts)");
    }
}
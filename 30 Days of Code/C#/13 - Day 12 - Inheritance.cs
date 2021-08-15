//Day 12: Inheritance

class Student : Person{
    private int[] testScores;
    
    public Student(string FN, string LN, int I, int[] scores):base(FN,LN,I)
        {
        this.testScores = scores;
    }
    
public char Calculate()
{
    int avg=0;
    int sum=0;

    for(int i=0;i<testScores.Length;i++)
    {
       sum+=testScores[i];
    }

     int n=testScores.Length;
     avg=sum/n;


    if(avg>=90 && avg<=100)
        return('O');
    else if(avg>=80 && avg<=90)
        return('E');
    else if(avg>=70 && avg<=80)
        return('A');
    else if(avg>=55 && avg<=70)
        return('P');
    else if(avg>=40 && avg<=55)
        return('D');
    else if(avg<40)
        return('T');
    return('X');
}
}

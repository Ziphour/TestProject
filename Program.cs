// Student grade calculator

int currentAssignments = 5;

string[] studentNames = ["Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" ];

int[] sophiaScoresList = [90, 86, 87, 98, 100, 94, 90];
int[] andrewScoresList = [92, 89, 81, 96, 90, 89 ];
int[] emmaScoresList = [90, 85, 87, 98, 68, 89, 89, 89];
int[] loganScoresist = [90, 95, 87, 88, 96, 96];
int[] beckyScores = [92, 91, 90, 91, 92, 92, 92];
int[] chrisScores = [84, 86, 88, 90, 92, 94, 96, 98];
int[] ericScores = [80, 90, 100, 80, 90, 100, 80, 90];
int[] gregorScores = [91, 91, 91, 91, 91, 91, 91];    


int[][] studentList = [sophiaScoresList, andrewScoresList, emmaScoresList, loganScoresist, beckyScores, chrisScores, ericScores, gregorScores];
// would like some way of making averagescore infinite? without including values    
decimal[] studentAverageScore = new decimal[14];


string assignedGrade = "";

int i = 0;
// Loop that finds all students scores and adds each students scores for their tests
// up and stores them as the average decimal in an array

foreach (int[] student in studentList)
{
    decimal Scoressum = 0;
    int j = 1;

    foreach (int score in student)
    {

        if (j <= 5)
        {
            Scoressum += score;

        }
        else if (j >= 5)
        {
            Scoressum += score /10;

        }
        j++;
    }

    // currentAssignments = student.Length;
    decimal averageCreditGrade = Scoressum / currentAssignments;
    studentAverageScore[i] = averageCreditGrade;
    i++;


}




// moves each total into new array





for (int l = 0; l < studentNames.Length; l++)
{
    if (studentAverageScore[l] >= 97)
    {
        assignedGrade = "A+";
    }
    else if (studentAverageScore[l] >= 93)
    {
        assignedGrade = "A";
    }
    else if (studentAverageScore[l] >= 90)
    {
        assignedGrade = "A-";
    }
    else if (studentAverageScore[l] >= 87)
    {
        assignedGrade = "B+";
    }
    else if (studentAverageScore[l] >= 83)
    {
        assignedGrade = "B";
    }
    else if (studentAverageScore[l] >= 80)
    {
        assignedGrade = "B-";
    }
    else if (studentAverageScore[l] >= 77)
    {
        assignedGrade = "C+";
    }
    else
    {
        assignedGrade = "F";
    }

    Console.WriteLine($"{studentNames[l]}:\t\t{studentAverageScore[l]}\t{assignedGrade}");
}

Console.WriteLine("Click enter to continue");
Console.ReadLine();
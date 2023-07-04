
//In the CypherCrescent Software Academy, there are two possible Programmes one can join – Frontend and Backend. Both programmes hold 
//classes on Tuesday and Thursday. However, the Backend holds an additional class on Monday, while the Frontend holds an additional class on
//Wednesday.
//- Each programme has a collection of Students, and each Student is associated with only one programme. Programmes also have a collection of 
//facilitators, and every facilitator is associated with just one programme. Both facilitator and student are humans. All humans have names, can 
//attend class, ask questions, and answer questions. They all attend classes in the same way but ask and answer questions differently. Students 
//can ask questions to facilitators and fellow students, while facilitators ask questions to students alone. Both students and facilitators can also 
//answer questions. Both give explanations when they answer, but a facilitator gives additional resources after explanations.
//Your task is to model the CypherCrescent Software Academy in OOP terms. Note that the attend class functionality has a weekday parameter;
//your program must first check to know which programme the human belongs then check if the weekday parameter is among the possible 
//weekdays for that programme. If it is not among the possible weekdays, it should display a message saying “No class today”, otherwise it should 
//say “The host will let you in shortly”, and after 5 seconds display another message “You’re in!”.
//Hint: Days of the week should be an enum.
//-To test your code, create an array of 10 humans (4 facilitators & 6 students) – 5 frontend and 5 backend. Using one loop, each of the 10 humans 
//should attempt to attend classes on Monday and Wednesday.

//school: programs
//programs: backend, frontend
//Humans: Facilitators, students
//human methods: attendClasses, askQuestions, answerQuestions
//weekdays: enums

using CcsaModel;

School ccsa = new School("CCSA");
ccsa.Course1 = new BackEnd();
ccsa.Course2 = new FrontEnd();

Student student1 = new Student("student1");
Student student2 = new Student("student2");
Student student3 = new Student("student3");
Student student4 = new Student("student4");
Student student5 = new Student("student5");
Student student6 = new Student("student6");
//for (int i = 1; i <= 6; i++)
//{

//    Student student = new Student($"student{i}");
//}
Facilitator teacher1 = new Facilitator("teacher1");
Facilitator teacher2 = new Facilitator("teacher2");
Facilitator teacher3 = new Facilitator("teacher3");
Facilitator teacher4 = new Facilitator("teacher4");
Student[] ourStudents = { student1, student2, student3, student4, student5, student6 };
Facilitator[] ourTeachers = { teacher1, teacher2, teacher3, teacher4 };
for(int  i = 0; i < ourStudents.Length; i++)
{
    if(i % 2 == 0)
    {
        ccsa.Course1.AddStudent(ourStudents[i]);
    }
    else
    {
        ccsa.Course2.AddStudent(ourStudents[i]);
    }
}

for (int i = 0; i < ourTeachers.Length; i++)
{
    if (i % 2 == 0)
    {
        ccsa.Course1.AddFacilitator(ourTeachers[i]);
    }
    else
    {
        ccsa.Course2.AddFacilitator(ourTeachers[i]);
    }
}
Human[] members = { student1, student2, student3, student4, student5, student6, teacher1, teacher2, teacher3, teacher4};

for(int i = 0; i < members.Length; i++)
{
    if(i >= 4)
    {
        members[i].AttendClass(Weekdays.Monday);
    }
    else
    {
        members[i].AttendClass(Weekdays.Wednesday);
    }
}



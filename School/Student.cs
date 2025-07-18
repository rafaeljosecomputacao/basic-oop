namespace School
{
    internal class Student
    {
        public string Name;
        public double Grade1, Grade2, Grade3;

        public double FinalGrade() 
        { 
            return Grade1 + Grade2 + Grade3;
        }

        public bool StudentPassing()
        {
            if(FinalGrade() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double RemainingGrade()
        {
            return 60.0 - FinalGrade();
        }
    }
}

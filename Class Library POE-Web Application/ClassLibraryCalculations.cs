using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_Library_POE_Web_Application
{
    public class ClassLibraryCalculations
    {
        //Method to calculate the self study hours per week
        public int selfStudyHoursPerWeek_calculation(int numberOfCredits, int numberOfWeeks, int classHourPerWeek)
        {
            int selfStudyHoursPerWeek;

            selfStudyHoursPerWeek = (numberOfCredits * 10) / numberOfWeeks - classHourPerWeek;

            return selfStudyHoursPerWeek;
        }
        //Method to calculate the remaining self study hours
        public int calculateRecordedStudy(int selfStudy, int recordedStudyHours)
        {
            int record;

            record = selfStudy - recordedStudyHours;

            return record;
        }
    }
}

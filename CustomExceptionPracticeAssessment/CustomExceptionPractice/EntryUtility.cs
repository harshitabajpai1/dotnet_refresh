using System;
using System.Text.RegularExpressions;
namespace CustomExeption
{
    class EntryUtility
    {
        public bool validateEmployeeId(String employeeId)
        {
            string pattern = @"^GOAIR/\d{4}$";
            //eg: GOAIR/7385

            if (Regex.IsMatch(employeeId, pattern))
            {
                return true;
            }
            else
            {
                throw new InvalidEntryException("Invalid Employee Id");
            }
        }

        public bool validDuration(int duration)
        {
            if(duration >= 1 && duration <= 5)
            {
                return true;
            }
            else
            {
                throw new InvalidEntryException("Invalid Duration");
            }
        }
    }
}
using System;
using System.Text.RegularExpressions;

namespace TechStore
{
    public class GadgetValidator
    {
        public bool ValidateGadgetID(string gadgetID)
        {
            string pattern = @"^[A-Z]\d{3}$";
            if (Regex.IsMatch(gadgetID, pattern))
            {
                return true;
            }
            else
            {
                throw new InvalidGadgetException("Invalid Gadget ID");
            }
        }

        public bool ValidateWarrantyPeriod(int period)
        {
            if (period >= 6 && period <= 36)
            {
                return true;
            }
            else
            {
                throw new InvalidGadgetException("Invalid Warranty Period");
            }
        }
    }
}

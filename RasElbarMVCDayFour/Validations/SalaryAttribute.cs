using System.ComponentModel.DataAnnotations;

namespace RasElbarMVCDayFour.Validations
{
    public class SalaryAttribute : ValidationAttribute
    {
        public override bool IsValid(object? value)
        {
            if(value == null)
                return true;
            if (value is decimal salary)
            {
                return salary % 1000 == 0;
            }
            return false;
        }
    }
}

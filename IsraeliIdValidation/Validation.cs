using System;

namespace IsraeliIdValidation
{
    public class Validation
    {
          public static bool IsValidIsraeliIdNumber(string personalId)
        {
            int sumOfAllInts = 0;
            int multiplier = 1;
            int index;

            if (string.IsNullOrEmpty(personalId) || personalId == "0")
                return false;

            personalId = personalId.PadLeft(11,'0');

            if (personalId == "00000000000")
                return false;

            for (index = 0; index <= 10; index++)
            {
                int number;
                if (multiplier == 1)
                {
                    number = (Convert.ToInt32(personalId.Substring(index, 1)) * multiplier);
                    multiplier = 2;
                }
                else
                {
                    number = (Convert.ToInt32(personalId.Substring(index, 1)) * multiplier);
                    multiplier = 1;
                }

                if ((number > 9))
                    number = ((number % 10) + 1);

                sumOfAllInts += number;
            }
            sumOfAllInts = (sumOfAllInts % 10);

            if ((sumOfAllInts > 0))
                return false;
            else
                return true;
        }
    }
}

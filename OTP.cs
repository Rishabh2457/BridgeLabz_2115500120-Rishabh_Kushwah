using System;

class OTP
{
    // Method to generate 6 Digit OTP
    public static int Generate6DigitOTP()
    {
        Random random = new Random();
        return random.Next(100000, 1000000);
    }

    // Method to check if OTPs are unique
    public static bool IsUniqueOTPs(int[] otps)
    {
        for (int i = 0; i < otps.Length; i++)
        {
            for (int j = i + 1; j < otps.Length; j++)
            {
                if (otps[i] == otps[j])
                {
                    return false;
                }
            }
        }
        return true;
    }

    static void Main(string[] args)
    {
        // Initialize array
        int[] otps = new int[10];

        // Loop to fill the OTPs array
        for (int i = 0; i < 10; i++)
        {
            otps[i] = Generate6DigitOTP();
        }

        // Check conditions of unique OTPs and display output
        if (IsUniqueOTPs(otps))
        {
            Console.WriteLine(string.Format("All OTPs are unique"));
        }
        else
        {
            Console.WriteLine(string.Format("All OTPs are not unique"));
        }
    }
}




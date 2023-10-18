using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_session6
{
        public class Number_Cheking
        {
            public static bool Cellphone_checking(string text2)
            {
            int celluser;
            bool number = int.TryParse(text2, out celluser);

            if (text2.StartsWith("+98"))
                {
                    if (text2.Length == 13)
                    {
                        text2.Replace("+98", "0");
                    return true;
                    }
                    else
                    {
                        MessageBox.Show("Please insert a valid phone number");
                    return false;
                    }
                }
                        if (!number)
                        {
                            MessageBox.Show("Please insert a valid phone number");
                        }
                else if (text2.StartsWith("0"))
                {
                    if (text2.Length != 11)
                    {
                        {
                            MessageBox.Show("Please insert a valid phone number");
                        return false;
                        }
                    }
                else
                {
                    return true;
                }
                }
                else
                {
                    MessageBox.Show("Please insert a valid number");
                return false;
                }
            return true ;

            }
            public static bool IsNumber(string text, string name)
            {
                int right;
                bool correct = int.TryParse(text, out right);

                if (!correct)
                {
                    MessageBox.Show($"Please insert a valid number for {name}");
                    correct = int.TryParse(text, out right);
                return false;

                }
                return true;
            }

        }
    
}
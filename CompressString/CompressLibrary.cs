using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompressLibrary
{
    public static class CompressClass
    {
        public static string Compression(string inputData)
        {
            if (inputData == string.Empty)
            {
                return "Входные данные пустые";
            }
            else
            {
                try
                {
                    string outputData = "";
                    int i = 0;
                    while (i < inputData.Length)
                    {
                        int count = 1;
                        while (i + 1 < inputData.Length && inputData[i + 1] == inputData[i])
                        {
                            count++;
                            i++;
                        }
                        outputData += inputData[i];
                        if (count > 1)
                        {
                            outputData += count;
                        }
                        i++;
                    }
                    return outputData;
                }
                catch (Exception e)
                {
                    return e.ToString();
                }
            }
        }
        public static string Decompression(string inputData)
        {
            string outputData = "";
            if (inputData == string.Empty)
            {
                return "Входные данные пустые";
            }
            else
            {
                for (int i = 0; i < inputData.Length; i++)
                {

                    char currentChar = inputData[i];

                    if (i + 1 < inputData.Length && char.IsDigit(inputData[i + 1]))
                    {
                        string digitStr = "";
                        int j = i + 1;
                        while (j < inputData.Length && char.IsDigit(inputData[j]))
                        {
                            digitStr += inputData[j];
                            j++;
                        }

                        int repeatCount = int.Parse(digitStr);
                        outputData += new string(currentChar, repeatCount);
                        i = j - 1;
                    }
                    else
                    {
                        outputData += currentChar;
                    }
                }

            }
            return outputData;
        }
    }
}

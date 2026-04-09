namespace StandardLogs
{
    public class StandardizationClass : LogInfo, IStandardLog
    {
        public StandardizationClass(string path)
        {
            base.path = path;
        }

        public void ProcessAndSave()
        {
            string[] lines = File.ReadAllLines(base.path);
            string dir = Path.GetDirectoryName(base.path);
            string fileName = Path.GetFileNameWithoutExtension(base.path);
            string outputPath = Path.Combine(dir, $"{fileName}_normalized.txt");
            string problemsPath = Path.Combine(dir, $"{fileName}_problems.txt");

            using (var writerOutput = new StreamWriter(outputPath))
            using (var writerProblems = new StreamWriter(problemsPath))
            {
                foreach (string line in lines)
                {
                    try
                    {
                        if (TryParseLine(line, out string normalizedLine))
                        {
                            writerOutput.WriteLine(normalizedLine);
                        }
                        else
                        {
                            writerProblems.WriteLine(line);
                        }
                    }
                    catch (Exception)
                    {
                        // Ошибка парсинга → считаем строку невалидной
                        writerProblems.WriteLine(line);
                    }
                }
            }

        }

        private bool TryParseLine(string line, out string normalizedLine)
        {
            normalizedLine = null;

            // Null — невалидная запись
            if (string.IsNullOrWhiteSpace(line))
                return false;

            // Определяем формат по символу разделителю даты
            if (line.Length >= 5)
            {
                if (line[4] == '-')
                    return TryParseFormat2(line, out normalizedLine);
                if (line[4] == '.')
                    return TryParseFormat1(line, out normalizedLine);
            }

            return false;
        }

        private bool TryParseFormat1(string line, out string normalizedLine)
        {
            normalizedLine = null;

            // Ищем первые три пробела для частей
            int firstSpace = line.IndexOf(' ');
            int secondSpace = line.IndexOf(' ', firstSpace + 1);
            int thirdSpace = line.IndexOf(' ', secondSpace + 1);

            if (firstSpace == -1 || secondSpace == -1 || thirdSpace == -1)
                return false;

            string dateStr = line.Substring(0, firstSpace);
            string timeStr = line.Substring(firstSpace + 1, secondSpace - firstSpace - 1);
            string levelStr = line.Substring(secondSpace + 1, thirdSpace - secondSpace - 1);
            string message = line.Substring(thirdSpace + 1);

            if (!DateTime.TryParseExact(dateStr, "dd.MM.yyyy", null,
                    System.Globalization.DateTimeStyles.None, out DateTime date))
                return false;

            if (!TimeSpan.TryParse(timeStr, out TimeSpan _))
                return false;

            string normalizedDate = date.ToString("dd-MM-yyyy");
            string normalizedLevel = NormalizeLevel(levelStr);
            string method = "DEFAULT";

            normalizedLine = $"{normalizedDate}\t{timeStr}\t{normalizedLevel}\t{method}\t{message}";
            return true;
        }

        private bool TryParseFormat2(string line, out string normalizedLine)
        {
            normalizedLine = null;

            string[] parts = line.Split('|');
            if (parts.Length < 5)
                return false;

            string dateTimePart = parts[0].Trim();
            int spaceIdx = dateTimePart.IndexOf(' ');
            if (spaceIdx == -1)
                return false;
            // Ищем первые три пробела для частей
            string dateStr = dateTimePart.Substring(0, spaceIdx);
            string timeStr = dateTimePart.Substring(spaceIdx + 1);
            string levelStr = parts[1].Trim();
            string method = parts[3].Trim();
            string message = parts[4];

            
            for (int i = 5; i < parts.Length; i++)
            {
                message += "|" + parts[i];
            }
            message = message.Trim();

            if (!DateTime.TryParseExact(dateStr, "yyyy-MM-dd", null,
                    System.Globalization.DateTimeStyles.None, out DateTime date))
                return false;

            if (!TimeSpan.TryParse(timeStr, out TimeSpan _))
                return false;

            string normalizedDate = date.ToString("dd-MM-yyyy");
            string normalizedLevel = NormalizeLevel(levelStr);
            string normalizedMethod = string.IsNullOrEmpty(method) ? "DEFAULT" : method;

            normalizedLine = $"{normalizedDate}\t{timeStr}\t{normalizedLevel}\t{normalizedMethod}\t{message}";
            return true;
        }


        // Тут нормализуем уровни логирования
        private string NormalizeLevel(string level)
        {
            return level.ToUpperInvariant() switch
            {
                "INFORMATION" => "INFO",
                "WARNING" => "WARN",
                _ => level
            };
        }
    }
}

public class ReadCsv
{
    public List<string[]> ReadRows(string filePath)
    {
        List<string[]> rows = new List<string[]>();

        foreach (string line in File.ReadLines(filePath))
        {
            if (!string.IsNullOrWhiteSpace(line))
            {
                rows.Add(line.Split('~'));
            }
        }

        return rows;
    }
}

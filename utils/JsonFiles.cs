using System.Collections.Generic;
using System.IO;
using System.Text.Json;

public class JsonFiles
{
    public void LoadJson()
    {
        using (StreamReader r = new StreamReader("file.json"))
        {
            string json = r.ReadToEnd();
            dynamic items = JsonSerializer.Deserialize<List<object>>(json);
        }
    }
}